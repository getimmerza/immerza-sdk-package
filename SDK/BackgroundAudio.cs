using UnityEngine;

namespace ImmerzaSDK
{
    public class BackgroundAudio : MonoBehaviour
    {
        [SerializeField] private AudioSource backgroundAudioSrc;

        private void Start()
        {
            if (!backgroundAudioSrc.isPlaying)
            {
                backgroundAudioSrc.loop = true;
                backgroundAudioSrc.Play();
            }
        }
    }

}