#define BUILD_BUNDLE
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using SharpCompress.Writers;
using SharpCompress.Common;
using System;
using ImmerzaSDK;
using ImmerzaSDK.Types;
using ImmerzaSDK.Util;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using Newtonsoft.Json.Linq;

public class ImmerzaSceneBundler : EditorWindow
{
    private const string BuildTargetWindows = "Windows";
    private const string BuildTargetAndroid = "Android";

    private VisualTreeAsset treeAsset = null;
    private SceneAsset sceneToExport = null;

    private ListView scenesView = null;
    private TextField path = null;
    private TextField scriptsPath = null;
    private Button exportBtn = null;
    private Button refreshBtn = null;
    private Label successLabel = null;
    private Toggle openExportFolderTgl = null;
    private DropdownField buildTargetCmb = null;

    //string unityAssembliesPath = Path.Combine(EditorApplication.applicationContentsPath, "Managed");
    //string generalAssembliesPath = Path.Combine(EditorApplication.applicationContentsPath, "UnityReferenceAssemblies", "unity-4.8-api");

    private string sceneCachePath = Path.Combine(Path.GetDirectoryName(Application.dataPath), "ImmerzaSceneCache");

    private enum CompilationState
    {
        FAILED,
        NO_FILES,
        SUCCESS
    };

    [MenuItem("Immerza/Scene Bundler")]
    public static void ShowSceneBundler()
    {
        ImmerzaSceneBundler window = GetWindow<ImmerzaSceneBundler>();
        window.titleContent = new GUIContent("Immerza Scene Bundler");
    }

    public void CreateGUI()
    {
        VisualElement root = rootVisualElement;
        if (ImmerzaUtil.IsRunningInPackage())
		{
			treeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Packages/com.actimi.immerzasdk/Editor/Immerza/ImmerzaSceneBundlerUI.uxml");
		}
		else
		{
			treeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/Immerza/ImmerzaSceneBundlerUI.uxml");
		}
		root.Add(new Label());
		Image immerzaLogo = new Image();
        immerzaLogo.scaleMode = ScaleMode.ScaleToFit;
		if (ImmerzaUtil.IsRunningInPackage())
		{
            immerzaLogo.sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Packages/com.actimi.immerzasdk/Editor/Immerza/Assets/ImmerzaLogo.png");
		}
		else
		{
            immerzaLogo.sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Editor/Immerza/Assets/ImmerzaLogo.png");
		}

        immerzaLogo.style.marginTop = 20.0f;
        immerzaLogo.style.marginLeft = 10.0f;
        immerzaLogo.style.marginRight = 10.0f;
        immerzaLogo.style.marginBottom = 5.0f;
        root.Add(immerzaLogo);

        treeAsset.CloneTree(root);

        scenesView = root.Q<ListView>("SceneList");
        path = root.Q<TextField>("ExportPath");
        scriptsPath = root.Q<TextField>("ScriptsPath");
        exportBtn = root.Q<Button>("ExportButton");
        exportBtn.SetEnabled(false);
        exportBtn.style.backgroundColor = new UnityEngine.Color(0.2f, 0.2f, 0.2f);
        exportBtn.style.color = new UnityEngine.Color(0.3f, 0.3f, 0.3f);
        refreshBtn = root.Q<Button>("RefreshButton");
        successLabel = root.Q<Label>("SuccessLabel");
        successLabel.visible = false;

        openExportFolderTgl = root.Q<Toggle>("OpenExportFolder");

        buildTargetCmb = root.Q<DropdownField>("BuildTarget");
        buildTargetCmb.choices.Add(BuildTargetAndroid);
        buildTargetCmb.choices.Add(BuildTargetWindows);
        buildTargetCmb.value = BuildTargetAndroid;

        UpdateSceneList();

        scenesView.selectionChanged += SceneSelected;
        exportBtn.clicked += ExportScene;
        refreshBtn.clicked += UpdateSceneList;
    }

    private void UpdateSceneList()
    {
        scenesView.ClearSelection();
        scenesView.itemsSource = null;

        string[] allSceneGuids = AssetDatabase.FindAssets("t:SceneAsset", new[] { "Assets" });
        List<SceneAsset> allScenes = new List<SceneAsset>();

        foreach (string guid in allSceneGuids)
        {
            allScenes.Add(AssetDatabase.LoadAssetAtPath<SceneAsset>(AssetDatabase.GUIDToAssetPath(guid)));
        }

        scenesView.makeItem = () => new Label();
        scenesView.bindItem = (item, index) => { (item as Label).text = allScenes[index].name; };
        scenesView.itemsSource = allScenes;

        exportBtn.SetEnabled(false);
        exportBtn.style.backgroundColor = new UnityEngine.Color(0.2f, 0.2f, 0.2f);
        exportBtn.style.color = new UnityEngine.Color(0.3f, 0.3f, 0.3f);
    }

    private void SceneSelected(IEnumerable<object> scenes)
    {
        if (!scenes.Any()) { return; }

        SceneAsset scene = scenes.First() as SceneAsset;
        if (scene == null)
        {
            return;
        }

        sceneToExport = scene;

        exportBtn.SetEnabled(true);
        exportBtn.style.backgroundColor = new UnityEngine.Color(0.4f, 0.4f, 0.4f);
        exportBtn.style.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f);
    }

    private void ExportScene()
    {
        ImmerzaUtil.InitCrcTable();

        EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(sceneToExport));

        string bundleDir = Path.Combine(Path.GetDirectoryName(Application.dataPath), path.text);

        SceneMetadata sceneMetadata = new SceneMetadata();
        AssetMetadata assetMetadata = new AssetMetadata();

        List<string> assetPaths = new();

        if (!Directory.Exists(bundleDir))
        {
            Directory.CreateDirectory(bundleDir);
        }

        string scenePath = SceneManager.GetActiveScene().path;

        assetMetadata.AddAsset("ImmerzaScene", scenePath);

        if (ImmerzaUtil.IsRunningInPackage())
        {
            ImmerzaUtil.AddAssetPath(assetPaths, "Packages/com.actimi.immerzasdk/Editor/Immerza/Assets/DummyFile.txt");
            assetMetadata.AddAsset("Gen", "NONE");
        }
        else
        {
            ImmerzaUtil.AddAssetPath(assetPaths, "Assets/Editor/Immerza/Assets/DummyFile.txt");
            assetMetadata.AddAsset("Gen", "NONE");
        }

#if BUILD_BUNDLE
        AssetBundleBuild[] exportMap = new AssetBundleBuild[2];

        exportMap[0].assetBundleName = "immerza_scene";
        exportMap[0].assetNames = new[] { scenePath };

        exportMap[1].assetBundleName = "immerza_assets";
        exportMap[1].assetNames = assetPaths.ToArray();

        BuildTarget buildTarget = buildTargetCmb.value switch
        {
            BuildTargetWindows => BuildTarget.StandaloneWindows64,
            _ => BuildTarget.Android
        };

        BuildPipeline.BuildAssetBundles(bundleDir, exportMap, BuildAssetBundleOptions.ForceRebuildAssetBundle, buildTarget);
#endif
        sceneMetadata.assetMetaData = assetMetadata;

        try
        {
            File.Delete(Path.Combine(bundleDir, path.text));
            File.Delete(Path.Combine(bundleDir, path.text + ".manifest"));
            File.Delete(Path.Combine(bundleDir, "immerza_scene.manifest"));
            File.Delete(Path.Combine(bundleDir, "immerza_assets.manifest"));

            string archivePath = Path.Combine(bundleDir, "immerza_data.bundle");

            if (File.Exists(archivePath))
            {
                File.Delete(archivePath);
            }

#if BUILD_BUNDLE
            using (Stream stream = File.OpenWrite(archivePath))
            using (IWriter writer = WriterFactory.Open(stream, ArchiveType.Tar, SharpCompress.Common.CompressionType.GZip))
            {
                writer.Write("immerza_scene.bundle", Path.Combine(bundleDir, "immerza_scene"));
                writer.Write("immerza_assets.bundle", Path.Combine(bundleDir, "immerza_assets"));
            }

            byte[] dataScene = File.ReadAllBytes(Path.Combine(bundleDir, "immerza_scene"));
            byte[] dataAssets= File.ReadAllBytes(Path.Combine(bundleDir, "immerza_assets"));

            byte[] combined = new byte[dataScene.Length + dataAssets.Length];
            Buffer.BlockCopy(dataScene, 0, combined, 0, dataScene.Length);
            Buffer.BlockCopy(dataAssets, 0, combined, dataScene.Length, dataAssets.Length);

            uint crc = 0xffffffff;
            crc = ImmerzaUtil.ComputeChecksum(combined);
#else
            uint crc = 0xdeadbeef;
#endif
            sceneMetadata.hash = crc;
            sceneMetadata.sceneID = "0";
            sceneMetadata.sdkVersion = ImmerzaUtil.IsRunningInPackage() ? GetPackageVersion() : "dev";
            sceneMetadata.isUsingBgMusic = FindAnyObjectByType<BackgroundAudio>(FindObjectsInactive.Include) != null;
            sceneMetadata.SaveMetaData(Path.Combine(bundleDir, "immerza_metadata.json"));

#if BUILD_BUNDLE
            File.Delete(Path.Combine(bundleDir, "immerza_scene"));
            File.Delete(Path.Combine(bundleDir, "immerza_assets"));
#endif
        }
        catch (Exception exc)
        {
            UnityEngine.Debug.LogException(exc);
            SetSuccessMsg(false);
            return;
        }

        SetSuccessMsg(true);

        if (openExportFolderTgl.value)
        {
            Process.Start("explorer.exe", bundleDir);
        }
    }

    private void SetSuccessMsg(bool success, string message)
    {
        successLabel.visible = true;
        if (success)
        {
            successLabel.style.color = new Color(0.36f, 1.0f, 0.36f);
            successLabel.text = "Scene successfully exported.";
        }
        else
        {
            successLabel.style.color = new Color(1.0f, 0.36f, 0.36f);
            successLabel.text = message == null ? message : "Scene export failed.";
        }
    }

    private string GetPackageVersion()
    {
        TextAsset packageAsset = (TextAsset)AssetDatabase.LoadAssetAtPath("Packages/com.actimi.immerzasdk/package.json", typeof(TextAsset));
        JObject jsonPackage = JObject.Parse(packageAsset.text);

        return jsonPackage["version"]?.ToString();
    }

    private void SetSuccessMsg(bool success)
    {
        SetSuccessMsg(success, null);
    }
}
