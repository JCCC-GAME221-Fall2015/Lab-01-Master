using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

public class ScriptUnityTool : MonoBehaviour {

    [MenuItem("Tool Creation/Create folder")]
	public static void CreateFolder()
    {
        //create the materials folder
        AssetDatabase.CreateFolder("Assets", "Materials");
        //create the materials folder txt
        System.IO.File.WriteAllText(Application.dataPath + "/Materials/folderStructure.txt", "This folder is for storing materials.");

        //create the textures folder
        AssetDatabase.CreateFolder("Assets", "Textures");
        //create the textures folder txt
        System.IO.File.WriteAllText(Application.dataPath + "/Textures/folderStructure.txt", "This folder is for storing textures.");

        //create the prefabs folder
        AssetDatabase.CreateFolder("Assets", "Prefabs");
        //create the prefabs folder txt
        System.IO.File.WriteAllText(Application.dataPath + "/Prefabs/folderStructure.txt", "This folder is for storing prefabs.");

        //create the scripts folder
        AssetDatabase.CreateFolder("Assets", "Scripts");
        //create the scripts folder txt
        System.IO.File.WriteAllText(Application.dataPath + "/Scripts/folderStructure.txt", "This folder is for storing scripts.");

        //create the scenes folder
        AssetDatabase.CreateFolder("Assets", "Scenes");
        //create the scenes folder txt
        System.IO.File.WriteAllText(Application.dataPath + "/Scenes/folderStructure.txt", "This folder is for storing scenes.");

        //create the animations folder
        AssetDatabase.CreateFolder("Assets", "Animations");
        //create the animations folder txt
        System.IO.File.WriteAllText(Application.dataPath + "/Animations/folderStructure.txt", "This folder is for storing raw animations.");

        //create the animation contollers folder nested in the animations folder
        AssetDatabase.CreateFolder("Assets/Animations", "AnimationControllers");
        //create the animations controller txt
        System.IO.File.WriteAllText(Application.dataPath + "/AnimationControllers/folderStructure.txt", 
                                    "This folder is for storing animations.");

        //refresh the project to submit the changes
        AssetDatabase.Refresh();
    }
}
