using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

public class ScriptEditorOrganizer : MonoBehaviour {
    
    
    [MenuItem("Tool Creation/Create folder")]
    public static void Createfolder()
    {
        //Create All the project folders.
        //Assets/Dynamic Assets
        AssetDatabase.CreateFolder("Assets", "Dynamic Assets");

        //Assets/Dynamic Assets/Resources
        AssetDatabase.CreateFolder("Assets/Dynamic Assets", "Resources");

        //Assets/Dynamic Assets/Resources/Animations
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Animations");
        //Assets/Dynamic Assets/Resources/Animations/Sources
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Animations", "Sources");

        //Assets/Dynamic Assets/Resources/Animation Controllers
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Animation Controllers");

        //Assets/Dynamic Assets/Resources/Effects
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Effects");
        
        //Assets/Dynamic Assets/Resources/Models
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Models");
        //Assets/Dynamic Assets/Resources/Models/Characters
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Models", "Characters");
        //Assets/Dynamic Assets/Resources/Models/Environment
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Models", "Environment");

        //Assets/Dynamic Assets/Resources/Prefabs
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Prefabs");
        //Assets/Dynamic Assets/Resources/Prefabs/Common
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Prefabs", "Common");

        //Assets/Dynamic Assets/Resources/Sounds
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Sounds");
        //Assets/Dynamic Assets/Resources/Sounds/Music
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Sounds", "Music");
        //Assets/Dynamic Assets/Resources/Sounds/Music/Common
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Sounds/Music", "Common");
        //Assets/Dynamic Assets/Resources/Sounds/SFX
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Sounds", "SFX");
        //Assets/Dynamic Assets/Resources/Sounds/SFX/Common
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Sounds/SFX", "Common");
        //Assets/Dynamic Assets/Resources/Sounds
        AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Textures");
        //Assets/Dynamic Assets/Resources/folderStructure.txt
        System.IO.File.WriteAllText(Application.dataPath + "Assets/Dynamic Assets/Resources", "Place all your dynamic resources in this folder.");

        //Assets/Editor
        AssetDatabase.CreateFolder("Assets", "Editor");
        //Assets/Editor/folderSctructure.txt
        System.IO.File.WriteAllText(Application.dataPath + "Assets/Editor", "Place editor scripts in this folder.");

        //Assets/Extensions
        AssetDatabase.CreateFolder("Assets", "Extensions");
        //Assets/Extensions/folderStructure.txt
        System.IO.File.WriteAllText(Application.dataPath + "Assets/Extensions", "Place extensions in this folder.");

        //Assets/Gizmos
        AssetDatabase.CreateFolder("Assets", "Gizmos");
        //Assets/Gizmos/folderStructure.txt
        System.IO.File.WriteAllText(Application.dataPath + "Assets/Gizmos", "Place Gizmos in this folder.");

        //Assets/Plugins
        AssetDatabase.CreateFolder("Assets", "Plugins");
        //Assets/Plugins/folderStructure.txt
        System.IO.File.WriteAllText(Application.dataPath + "Assets/Plugins", "Place plugins in this folder.");

        //Assets/Scripts
        AssetDatabase.CreateFolder("Assets", "Shaders");
        //Assets/Scripts/folderStructure.txt
        System.IO.File.WriteAllText(Application.dataPath + "Assets/Shaders", "Place Shaders in this folder.");



        AssetDatabase.Refresh();
    }


}
