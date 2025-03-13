using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;

namespace ImmerzaSDK
{
    public class BreathingDetection : MonoBehaviour
    {
        private InputDevice leftHandDevice;
        private InputDevice rightHandDevice;

        // Events Actions for Observations
        public static event Action ExhaleStarted;
        public static event Action ExhaleFinished;
        public static event Action<string, float, float, float> RespiratoryRatePost;

        private float _lastHoldTime = 0;
        private float _lastInhaleTime = 0;
        private float _lastExhaleTime = 0;


        [Space]
        [Header("Extras")]
        private int holdFilerConstant = 3;
        [SerializeField] private int inhaleFilerConstant = 3;
        private int exhaleFilerConstant = 3;
        private float checkDisableTime = 0;
        private float disableTimeContsant = 3f;
        public float inhaleTime = 0, exhaleTime = 0, holdTime = 0;
        public int breathCount = 0;
        public int breathCount2 = 0;
        public float totalTime = 0;
        public float postTime = 30f;
        public bool isBreathCompleted;
        public bool isStart;
        public bool isFinish;
        public bool isStaticScene;
        public bool isFirstTimeRespiratory = true;
        private int velocityThreshold = 25;
        private float maxHoldVelocity = 0.0020f;     // 0.005                                             // ----------- 29
        private int holdFilter, inhaleFilter, exhaleFilter;
        private float currentPos, tempPosZ, tempPosY;
        private float sampleTime = 0.2f, time;                      // sampleTime = 0.2f
        private bool breathControl;
        public int breathDirection = 0;                             // Hold = 0 , Inhale = -1 , Exhale = 1 ,
        LinkedList<float> zShortBuffer = new LinkedList<float>();
        LinkedList<float> zLongBuffer = new LinkedList<float>();
        LinkedList<float> yShortBuffer = new LinkedList<float>();
        LinkedList<float> yLongBuffer = new LinkedList<float>();
        private Vector3 tempVector;
        public float totalInhaleTime = 0, totalExhaleTime = 0, totalHoldTime = 0;
        public float lastInhaleTime = 0, lastExhaleTime = 0, lastHoldTime = 0;
        public float calculatedLastInhaleTime, calculatedLastExhaleTime, calculatedLastHoldTime;

        // breathCount/time 
        private int lowBreath = 8, highBreath = 16;

        public string breathAPI = "average";

        public string breathLastAPIHold = "correct";
        public string breathLastAPIInhale = "correct";
        public string breathLastAPIExhale = "correct";

        public int countOfGoodInhale = 0;
        public int countOfGoodExhale = 0;

        private bool breathControl2;

        public static BreathingDetection Instance { get; private set; }

        private bool isLeftHand = true;

        private Vector3 controllerPos;

        // Singleton
        private void Awake()
        {
            DontDestroyOnLoad(this);

            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }


            isStart = true;
            isFinish = false;
            GetHandDevices();
        }


        private void GetHandDevices()
        {
            // Find the left hand XR controller device
            leftHandDevice = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
            rightHandDevice = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        }

        private void OnDisable()
        {
            isStart = false;
            isFinish = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (leftHandDevice.isValid && rightHandDevice.isValid)
            {
                // Check for "X" button press on the left hand
                bool xButtonPressed = leftHandDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool xButtonValue) && xButtonValue;

                // Check for "A" button press on the right hand
                bool aButtonPressed = rightHandDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool aButtonValue) && aButtonValue;

                // Update isLeftHand based on button presses
                isLeftHand = xButtonPressed ? true : aButtonPressed ? false : isLeftHand;



                if (isBreathCompleted)
                {
                    isBreathCompleted = false;
                    RespiratoryRatePost?.Invoke("final", (float)((breathCount * 60) / totalTime), (float)(totalInhaleTime / breathCount), (float)(totalExhaleTime / breathCount));

                }

                //Start Control
                if (!isStart)
                {
                    return;
                }



                if (isFinish)
                {
                    breathDirection = 0;
                    return;
                }
                else
                {
                    BreathDetector();
                }

                Movement();

                MainEnvironmentChange();
            }
            else
            {
                GetHandDevices();
            }

        }

        private void MainEnvironmentChange()
        {
            float ratio = breathCount / totalTime;

            if (ratio < 0.13f)                                      // LOW Breath Count
            {
                breathAPI = "low";

            }
            else if (ratio > 0.26f)                                 // HIGH Breath Count
            {
                breathAPI = "high";
            }
            else                                                    // Avarage Breath Count
            {
                breathAPI = "average";
            }

        }

        private void BreathDetector()
        {

            // Velocity control, Detect controll velocity  
            if (!VelocityControl())
            {
                //cornerStatus.text = "PUT THE LEFT CONTROLLER ON YOUR BELLY";                                               // INFO TEXT
                return;
            }



            /*------------ Start Action ---------*/
            time += Time.deltaTime;

            totalTime += Time.deltaTime;
            if (time < sampleTime)
            {
                FilterInputValues();
                RespirationTimer();
            }
            else
            {
                RespirationCounter();
                time = 0;

            }

            postTime -= Time.deltaTime;
            if (postTime <= 0)
            {
                postTime = 30f;
                if (isFirstTimeRespiratory)
                {
                    isFirstTimeRespiratory = false;
                    RespiratoryRatePost?.Invoke("preliminary", (float)((breathCount * 60) / totalTime), (float)(totalInhaleTime / breathCount), (float)(totalExhaleTime / breathCount));
                }
                else
                {
                    RespiratoryRatePost?.Invoke("registered", (float)((breathCount * 60) / totalTime), (float)(totalInhaleTime / breathCount), (float)(totalExhaleTime / breathCount));

                }
            }
        }

        private bool VelocityControl()
        {
            Vector3 velocity, angularVelocity;

            // TO DO If velocity < kkk   then STOP
            if (isLeftHand)
            {
                // Try getting the linear velocity and angular velocity of the left hand
                bool hasVelocity = leftHandDevice.TryGetFeatureValue(CommonUsages.deviceVelocity, out velocity);
                bool hasAngularVelocity = leftHandDevice.TryGetFeatureValue(CommonUsages.deviceAngularVelocity, out angularVelocity);

                // Check if either velocity exceeds the threshold
                if ((hasVelocity && velocity.magnitude > 0.09f) ||
                    (hasAngularVelocity && angularVelocity.magnitude > 0.09f))
                {
                    velocityThreshold++;
                    if (velocityThreshold > 50) velocityThreshold = 50;
                }
                else
                {
                    velocityThreshold--;
                    if (velocityThreshold < -25) velocityThreshold = -25;
                }
            }
            else
            {
                // Try getting the linear velocity and angular velocity of the left hand
                bool hasVelocity = rightHandDevice.TryGetFeatureValue(CommonUsages.deviceVelocity, out velocity);
                bool hasAngularVelocity = rightHandDevice.TryGetFeatureValue(CommonUsages.deviceAngularVelocity, out angularVelocity);
                // Check if either velocity exceeds the threshold
                if ((hasVelocity && velocity.magnitude > 0.09f) ||
                    (hasAngularVelocity && angularVelocity.magnitude > 0.09f))
                {
                    velocityThreshold++;
                    if (velocityThreshold > 50) velocityThreshold = 50;
                }
                else
                {
                    velocityThreshold--;
                    if (velocityThreshold < -25) velocityThreshold = -25;
                }
            }

            if (velocityThreshold > 0)
            {
                breathDirection = 0;
                if (!isStaticScene)
                {
                    leftHandDevice.StopHaptics();
                    rightHandDevice.StopHaptics();

                }


                return false;
            }
            if (!isStaticScene)
            {
                if (isLeftHand)
                {
                    // Trigger small haptic feedback on the left controller
                    if (leftHandDevice.isValid)
                        leftHandDevice.SendHapticImpulse(0, 0.01f, 0.01f);

                    // Stop haptic feedback on the right controller
                    if (rightHandDevice.isValid)
                        rightHandDevice.StopHaptics();
                }
                else
                {
                    // Trigger small haptic feedback on the right controller
                    if (rightHandDevice.isValid)
                        rightHandDevice.SendHapticImpulse(0, 0.01f, 0.01f);

                    // Stop haptic feedback on the left controller
                    if (leftHandDevice.isValid)
                        leftHandDevice.StopHaptics();
                }
            }


            return true;
        }

        private void FilterInputValues()
        {
            if (isLeftHand)
            {
                leftHandDevice.TryGetFeatureValue(CommonUsages.devicePosition, out controllerPos);

            }
            else
            {
                rightHandDevice.TryGetFeatureValue(CommonUsages.devicePosition, out controllerPos);
            }

            bool isMinusY = controllerPos.y < 0 ? true : false;
            bool isMinusZ = controllerPos.z < 0 ? true : false;

            float currentPosZ = controllerPos.z;
            float currentPosY = controllerPos.y;

            Vector3 vectorAB = tempVector - controllerPos;

            float xComp = vectorAB.x;
            float yComp = vectorAB.y;
            float zComp = vectorAB.z;


            int zShortFilter = 20;
            int zLongFilter = 130;

            int yShortFilter = 20;
            int yLongFilter = 130;

            float holdFilterArray = 0.0003f; // holdFilterArray is not an array?

            zShortBuffer.AddFirst(controllerPos.z);
            while (zShortBuffer.Count > zShortFilter)
            {
                zShortBuffer.RemoveLast();
            }

            zLongBuffer.AddFirst(controllerPos.z);
            while (zLongBuffer.Count > zLongFilter)
            {
                zLongBuffer.RemoveLast();
            }

            yShortBuffer.AddFirst(controllerPos.y);
            while (yShortBuffer.Count > yShortFilter)
            {
                yShortBuffer.RemoveLast();
            }

            yLongBuffer.AddFirst(controllerPos.y);                  // HATAAA
            while (yLongBuffer.Count > yLongFilter)
            {
                yLongBuffer.RemoveLast();
            }

            float avgShortZ = zShortBuffer.Average();
            float avgLongZ = zLongBuffer.Average();

            float avgShortY = yShortBuffer.Average();
            float avgLongY = yLongBuffer.Average();

            if (checkDisableTime > disableTimeContsant)
            {
                holdFilterArray = 0.001f;
                leftHandDevice.SendHapticImpulse(0, 0.01f, 0.01f);
                rightHandDevice.SendHapticImpulse(0, 0.01f, 0.01f);
            }

            if (Mathf.Abs(avgShortZ - avgLongZ) < holdFilterArray && Mathf.Abs(avgShortY - avgLongY) < holdFilterArray)
            {
                holdFilter++;
                holdTime += Time.deltaTime;

                checkDisableTime += Time.deltaTime;
            }
            else if ((Mathf.Abs(avgShortZ - avgLongZ) > Mathf.Abs(avgShortY - avgLongY)))
            {
                if (avgShortZ > avgLongZ)
                {

                    inhaleFilter++;
                    inhaleTime += Time.deltaTime;
                    checkDisableTime = 0;
                }
                else if (avgShortZ < avgLongZ)
                {
                    exhaleFilter++;
                    exhaleTime += Time.deltaTime;

                    checkDisableTime = 0;
                }
                else
                {
                    checkDisableTime = 0;
                }
            }
            else
            {
                if (avgShortY > avgLongY)
                {

                    inhaleFilter++;
                    inhaleTime += Time.deltaTime;
                    checkDisableTime = 0;
                }
                else if (avgShortY < avgLongY)
                {
                    exhaleFilter++;
                    exhaleTime += Time.deltaTime;

                    checkDisableTime = 0;
                }
                else
                {
                    checkDisableTime = 0;
                }
            }
        }

        private void RespirationCounter()
        {
            if (holdFilter >= inhaleFilter && holdFilter >= exhaleFilter)
            {
                holdFilter = holdFilerConstant; exhaleFilter = 0; inhaleFilter = 0;             // holdFilter = 7;

                breathDirection = 0;

                //HOLD
                ExhaleFinished?.Invoke();

            }
            else if (inhaleFilter > exhaleFilter && inhaleFilter > holdFilter)
            {
                if (breathControl)
                {
                    breathControl = false;
                    breathCount2++;


                    _lastHoldTime = 0;
                    _lastExhaleTime = 0;
                    _lastInhaleTime = 0;

                    //breathingCountText.text = breathCount.ToString();                                               // INFO TEXT

                    // ---------- LAST API - for Inhale and Hold
                    if (lastInhaleTime > 1 && lastInhaleTime < 10.5f) // Breathing cycle sould be 1.5s between 2s for inhale
                    {
                        breathLastAPIInhale = "correct";
                        countOfGoodInhale++;
                    }
                    else
                        breathLastAPIInhale = "wrong";
                    if (lastHoldTime > 1f && lastHoldTime < 20f)     // Breathing cycle sould be 1s between 2s for hold(After exhale ?)
                        breathLastAPIHold = "correct";
                    else
                        breathLastAPIHold = "wrong";

                    // CALCULATED TIMES

                    calculatedLastInhaleTime = lastInhaleTime;
                    calculatedLastHoldTime = lastHoldTime;

                    lastInhaleTime = 0;
                    lastHoldTime = 0;           //--- LAST TIMES
                                                //lastExhaleTime = 0;

                }

                breathControl2 = true;
                inhaleFilter = inhaleFilerConstant; exhaleFilter = 0; holdFilter = 2;            // inhaleFilter = 9;
                breathDirection = -1;

                // INHALE
                ExhaleFinished?.Invoke();
            }
            else if (exhaleFilter >= inhaleFilter && exhaleFilter >= holdFilter)
            {
                if (breathControl2)
                {
                    breathControl2 = false;
                    breathCount++;
                    Debug.Log("BD - Breath Count: " + breathCount);


                    _lastHoldTime = 0;
                    _lastExhaleTime = 0;
                    _lastInhaleTime = 0;

                    // ---------- LAST API  - for exhale and hold
                    if (lastExhaleTime > 1.5f && lastExhaleTime < 20f)   // Breathing cycle sould be 1.5s between 2s for exhale
                    {
                        breathLastAPIExhale = "correct";
                        countOfGoodExhale++;
                    }

                    else
                        breathLastAPIExhale = "wrong";
                    if (lastHoldTime > 1f && lastHoldTime < 20f)         // Breathing cycle sould be 1s between 2s for hold(After Inhale ?)
                        breathLastAPIHold = "correct";
                    else
                        breathLastAPIHold = "wrong";

                    // CALCULATED TIMES
                    calculatedLastExhaleTime = lastExhaleTime;

                    lastExhaleTime = 0;                     //--- LAST TIMES
                                                            //lastInhaleTime = 0;
                    lastHoldTime = 0;
                }

                breathControl = true;
                inhaleFilter = 0; exhaleFilter = exhaleFilerConstant; holdFilter = 0;            // exhaleFilter = 9;
                breathDirection = 1;

                // EXHALE
                ExhaleStarted?.Invoke();
            }
            else
            {
                //TO DO ERROR
            }


        }

        private void RespirationTimer()
        {
            if (holdFilter >= inhaleFilter && holdFilter >= exhaleFilter)
            {
                totalHoldTime += Time.deltaTime;
                lastHoldTime += Time.deltaTime;                 // ---LAST TIME 

                //Debug.Log(" BD - Total Hold Time: " + totalHoldTime);
            }
            else if (inhaleFilter > exhaleFilter && inhaleFilter > holdFilter)
            {
                totalInhaleTime += Time.deltaTime;
                lastInhaleTime += Time.deltaTime;            // ---LAST TIME           

                //Debug.Log(" BD - Total Inhale Time: " + totalInhaleTime);
            }
            else if (exhaleFilter >= inhaleFilter && exhaleFilter >= holdFilter)
            {
                totalExhaleTime += Time.deltaTime;
                lastExhaleTime += Time.deltaTime;           // ---LAST TIME 

                //Debug.Log(" BD - Total Exhale Time: " + totalExhaleTime);
            }
            else
            {
                //TO DO ERROR
            }
        }

        private void Movement()
        {

            //--------------------------------------------------------------------------------------------------------------------
            if (_lastHoldTime < lastHoldTime)
            {
                _lastHoldTime = lastHoldTime;

            }
            else if (_lastInhaleTime < lastInhaleTime)
            {
                _lastInhaleTime = lastInhaleTime;
            }
            else if (_lastExhaleTime < lastExhaleTime)
            {
                _lastExhaleTime = lastExhaleTime;
            }
            else
            {
                // HOLD TIME

            }
        }


    }

}