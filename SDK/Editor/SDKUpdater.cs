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

        private const string ReleaseEndpoint = "https://api.github.com/repos/getimmerza/immerza-sdk-package/releases";

        private Label crtVersionField = null;
        private DropdownField versionField = null;
        private Button refreshBtn = null;
        private Button updateBtn = null;
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
            successLabel = root.Q<Label>("SuccessLabel");
            successLabel.visible = false;

            refreshBtn.clicked += Refresh;

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

        private async Awaitable<bool> GetReleases()
        {
            using UnityWebRequest releasesReq = UnityWebRequest.Get(ReleaseEndpoint);
            await releasesReq.SendWebRequest();

            if (releasesReq.result != UnityWebRequest.Result.Success)
            {
                SetSuccessMsg(false, "Network Error, couldn't get releases.");
                return false;
            }

            JArray releaseArray = JArray.Parse(releasesReq.downloadHandler.text);

            foreach (JObject release in releaseArray)
            {
                Release newRelease = new(
                    (string)release["tag_name"],
                    (string)release["tarball_url"]
                );

                releases.Add(newRelease);
            }

            return true;
        }

        private bool CheckVersion()
        {
            string chosenVersion = versionField.value;

            int compRes = CompareVersions(chosenVersion, versionField.value);

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
