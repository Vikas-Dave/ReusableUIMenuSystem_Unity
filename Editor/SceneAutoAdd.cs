using UnityEditor;
using UnityEngine;
using System.Linq;

[InitializeOnLoad]
public class SceneAutoAdd
{
    static SceneAutoAdd()
    {
        string scenePath = "Packages/com.yourname.mypackage/Runtime/MyScene.unity";

        // Get current Build Settings scenes
        var scenes = EditorBuildSettings.scenes.ToList();

        // Check if the scene is already in Build Settings
        if (!scenes.Any(s => s.path == scenePath))
        {
            scenes.Add(new EditorBuildSettingsScene(scenePath, true));
            EditorBuildSettings.scenes = scenes.ToArray();
            Debug.Log($"Scene added to Build Settings: {scenePath}");
        }
    }
}
