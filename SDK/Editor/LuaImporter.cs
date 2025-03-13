using UnityEngine;
using UnityEditor.AssetImporters;
using System.IO;
using ImmerzaSDK.Lua;
using UnityEditor;
using ImmerzaSDK.Util;
using System.Linq;
using System.Collections.Generic;

[ScriptedImporter(1, "lua", AllowCaching = true)]
public class LuaImporter : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        string newAssetName = Path.GetFileName(ctx.assetPath);
        LuaAsset newAsset = ScriptableObject.CreateInstance<LuaAsset>();
        newAsset.content = File.ReadAllText(ctx.assetPath);

        string iconPath = "Assets/Immerza/SDK/Editor/Assets/LuaIcon.png";
        Texture2D icon = AssetDatabase.LoadAssetAtPath<Texture2D>(iconPath);
        EditorGUIUtility.SetIconForObject(newAsset, icon);

        ctx.AddObjectToAsset(newAssetName, newAsset);
        ctx.SetMainObject(newAsset);

        TryIncludeLuaExtension();
    }

    private static void TryIncludeLuaExtension()
    {
        if (EditorSettings.projectGenerationUserExtensions.Contains("lua")) { return; }
        List<string> list = EditorSettings.projectGenerationUserExtensions.ToList();
        list.Add("lua");
        EditorSettings.projectGenerationUserExtensions = list.ToArray();
    }
}
