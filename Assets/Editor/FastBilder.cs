using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEditor;

public class FastBilder : EditorWindow
{
    [MenuItem("Window/FastBilder/OpenMainWindow")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(FastBilder));
    }

    void OnGUI()
    {
        if (GUILayout.Button("GiveAllMaterial"))
        {
           foreach(MeshRenderer mf in FindObjectsByType<MeshRenderer>(FindObjectsSortMode.None))
            {
                if (mf.GetComponent<SetTextures>()) mf.material = Resources.Load<Material>("MyObject");
            }
        }
    }
}
