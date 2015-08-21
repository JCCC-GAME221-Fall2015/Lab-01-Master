using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

public class ScriptEditorOrganizer : MonoBehaviour {
    
    
    [MenuItem("Tool Creation/Create folder")]
    public static void Createfolder()
    {
        AssetDatabase.CreateFolder("Assets", "Materials");
        System.IO.File.WriteAllText(Application.dataPath + "/Materials/folderStructure.txt", "This Folder is for storing materials!");
        AssetDatabase.CreateFolder("Assets", "Textures");
        System.IO.File.WriteAllText(Application.dataPath + "/Textures/folderStructure.txt", "This Folder is for storing textures!");
        AssetDatabase.CreateFolder("Assets", "Prefabs");
        AssetDatabase.CreateFolder("Assets", "Scripts");
        AssetDatabase.CreateFolder("Assets", "Scenes");
        AssetDatabase.CreateFolder("Assets", "Animations");
        AssetDatabase.CreateFolder("Assets/Animations", "AnimationControllers");

        AssetDatabase.Refresh();
    }


}
