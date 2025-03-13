using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using System.IO;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using System;
using UnityEngine.Networking;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using Unity.Android.Gradle.Manifest;
using System.Collections;
using System.Threading.Tasks;

namespace ImmerzaSDK.Editor
{
    struct Release
    {
        public Release(string version, string url)
        {
            Version = version;
            Url = url;
        }

        public string Version { get; }
        public string Url { get; }
    }

    public class SDKUpdater : EditorWindow
    {
        [SerializeField] private VisualTreeAsset treeAsset = null;

        private const string ReleaseEndpoint = "https://api.ovok.com/fhir/Basic?code=sdk-release";

        private Label crtVersionField = null;
        private DropdownField versionField = null;
        private Button refreshBtn = null;
        private Button updateBtn = null;
        private ProgressBar downloadProgress = null;
        private Label successLabel = null;

        private List<Release> releases = new();

        private string crtVersion = "";

        [MenuItem("Immerza/SDK Updater")]
        public static void ShowSceneBundler()
        {
            SDKUpdater window = GetWindow<SDKUpdater>();
            window.titleContent = new GUIContent("Immerza SDK Updater");
        }

        public void CreateGUI()
        {
            VisualElement root = rootVisualElement;

            root.Add(new Label());

            treeAsset.CloneTree(root);

            crtVersionField = root.Q<Label>("CurrentVersion");
            versionField = root.Q<DropdownField>("VersionField");
            refreshBtn = root.Q<Button>("RefreshButton");
            updateBtn = root.Q<Button>("UpdateButton");
            downloadProgress = root.Q<ProgressBar>("DownloadProgress");
            successLabel = root.Q<Label>("SuccessLabel");
            successLabel.visible = false;

            refreshBtn.clicked += Refresh;
            updateBtn.clicked += () => UpdateSDK();

            crtVersion = AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Immerza/Version.txt").text;
            crtVersionField.text = crtVersion;

            versionField.RegisterCallback<PointerDownEvent>(evt => ChooseRelease());


            Refresh();
        }

        private async void Refresh()
        {
            SetButton(updateBtn, false);
            versionField.choices.Clear();

            bool success = await GetReleases();

            if (success)
            {
                foreach (Release release in releases)
                {
                    versionField.choices.Add(release.Version);
                }

                versionField.SetValueWithoutNotify(releases.ToArray()[0].Version);

                SetButton(updateBtn, CheckVersion());
            }
        }

        private void ChooseRelease()
        {
            SetButton(updateBtn, CheckVersion());
        }

        private async Task UpdateSDK()
        {
            Release chosenRelease = releases.Find((val) => val.Version == versionField.text);

            string accessToken = await GetAccessToken();

            

            /*using UnityWebRequest tarReq = UnityWebRequest.Get(chosenRelease.Url);
            UnityWebRequestAsyncOperation op = tarReq.SendWebRequest();

            while (!op.isDone)
            {
                downloadProgress.value = tarReq.downloadProgress;
                await Task.Delay(1);
            }*/

            Debug.Log("TEST");
        }

        private async Awaitable<bool> GetReleases()
        {
            string accessToken = await GetAccessToken();

            using UnityWebRequest releasesReq = UnityWebRequest.Get(ReleaseEndpoint);
            releasesReq.SetRequestHeader("Authorization", accessToken);
            await releasesReq.SendWebRequest();

            if (releasesReq.result != UnityWebRequest.Result.Success)
            {
                SetSuccessMsg(false, "Network Error, couldn't get releases.");
                Debug.LogError(releasesReq.downloadHandler.text);
                return false;
            }

            Debug.Log(releasesReq.downloadHandler.text);

            JObject releasesJson = JObject.Parse(releasesReq.downloadHandler.text);

            foreach (JObject release in releasesJson["entry"])
            {
                Release newRelease = new(
                    (string)release["resource"]["extension"][0]["valueString"],
                    (string)release["resource"]["extension"][0]["url"]
                );

                releases.Add(newRelease);
            }

            return true;
        }

        private async Awaitable<string> GetAccessToken()
        {
            WWWForm formData = new();
            formData.AddField("email", "defaultaccount@gmail.com");
            formData.AddField("password", "defaultaccount123");
            formData.AddField("clientId", "fc86ca24-e854-4c7f-bde1-fd5bb04d9a6d");

            using UnityWebRequest req = UnityWebRequest.Post("https://api.ovok.com/auth/login", formData);
            await req.SendWebRequest();

            if (req.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("API request was not successful! Error: " + req.result);
                return null;
            }

            JObject resObj = JObject.Parse(req.downloadHandler.text);

            string accessToken = "Bearer " + (string)resObj["access_token"];
            return accessToken;
        }

        private bool CheckVersion()
        {
            string chosenVersion = versionField.value;

            int compRes = CompareVersions(chosenVersion, crtVersion);

            return compRes > 0;
        }

        private void SetButton(Button button, bool activate)
        {
            if (activate)
            {
                button.SetEnabled(true);
                button.style.backgroundColor = new UnityEngine.Color(0.4f, 0.4f, 0.4f);
                button.style.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f);
            }
            else
            {
                button.SetEnabled(false);
                button.style.backgroundColor = new UnityEngine.Color(0.2f, 0.2f, 0.2f);
                button.style.color = new UnityEngine.Color(0.3f, 0.3f, 0.3f);
            }
        }

        private void SetSuccessMsg(bool success, string message)
        {
            successLabel.visible = true;
            if (success)
            {
                successLabel.style.color = new Color(0.36f, 1.0f, 0.36f);
            }
            else
            {
                successLabel.style.color = new Color(1.0f, 0.36f, 0.36f);
            }

            successLabel.text = message;
        }

        private int CompareVersions(string version1, string version2)
        {
            Regex regex = new(@"^(?:v)?(\d+)\.(\d+)\.(\d+)(?:-([a-zA-Z0-9]+))?$");

            var match1 = regex.Match(version1);
            var match2 = regex.Match(version2);

            if (!match1.Success || !match2.Success)
            {
                throw new ArgumentException("Invalid version format!");
            }

            int major1 = int.Parse(match1.Groups[1].Value);
            int minor1 = int.Parse(match1.Groups[2].Value);
            int patch1 = int.Parse(match1.Groups[3].Value);
            string preRelease1 = match1.Groups[4].Success ? match1.Groups[4].Value : "";

            int major2 = int.Parse(match2.Groups[1].Value);
            int minor2 = int.Parse(match2.Groups[2].Value);
            int patch2 = int.Parse(match2.Groups[3].Value);
            string preRelease2 = match2.Groups[4].Success ? match2.Groups[4].Value : "";

            if (major1 != major2) return major1.CompareTo(major2);
            if (minor1 != minor2) return minor1.CompareTo(minor2);
            if (patch1 != patch2) return patch1.CompareTo(patch2);

            if (string.IsNullOrEmpty(preRelease1) && !string.IsNullOrEmpty(preRelease2)) return 1;
            if (!string.IsNullOrEmpty(preRelease1) && string.IsNullOrEmpty(preRelease2)) return -1;

            return string.Compare(preRelease1, preRelease2, StringComparison.Ordinal);
        }
    }
}
