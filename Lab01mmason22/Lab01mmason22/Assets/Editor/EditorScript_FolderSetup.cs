using UnityEngine;
using System.Collections;
using UnityEditor;

public class EditorScript_FolderSetup : MonoBehaviour {
	[MenuItem("Tool Creation/Create Folders")]
	 public static void CreateFolders()
	 {
		AssetDatabase.CreateFolder ("Assets", "Materials");
		AssetDatabase.CreateFolder ("Assets", "Textures");
		AssetDatabase.CreateFolder ("Assets", "Prefabs");
		AssetDatabase.CreateFolder ("Assets", "Scripts");
		AssetDatabase.CreateFolder ("Assets", "Scenes");
		AssetDatabase.CreateFolder ("Assets", "Animations");
		AssetDatabase.CreateFolder ("Assets/Animations", "Animation Controllers");

		System.IO.File.WriteAllText (Application.dataPath + "/Materials", "Materials: This Folder is for storing materials.");
		System.IO.File.WriteAllText (Application.dataPath + "/Textures", "Textures: This Folder is for storing textures.");
		System.IO.File.WriteAllText (Application.dataPath + "/Prefabs", "Prefabs: This Folder is for storing prefabs.");
		System.IO.File.WriteAllText (Application.dataPath + "/Scripts", "Scripts: This Folder is for storing scripts.");
		System.IO.File.WriteAllText (Application.dataPath + "/Scenes", "Scenes: This Folder is for storing scenes.");
		System.IO.File.WriteAllText (Application.dataPath + "/Animations", "Animations: This Folder is for storing animations.");
		System.IO.File.WriteAllText (Application.dataPath + "/Animations/Animation Controllers", "Animation Controllers: This Folder is for storing animation controllers.");

		AssetDatabase.Refresh ();
	 }

	[MenuItem("Tool Creation/Create Extended Folders")]
	public static void CreateExtendedFolders()
	{
		AssetDatabase.CreateFolder ("Assets", "Dynamic Assets");
		AssetDatabase.CreateFolder ("Assets", "Editor");
		AssetDatabase.CreateFolder ("Assets", "Extensions");
		AssetDatabase.CreateFolder ("Assets", "Gizmos");
		AssetDatabase.CreateFolder ("Assets", "Plugins");
		AssetDatabase.CreateFolder ("Assets", "Scripts");
		AssetDatabase.CreateFolder ("Assets", "Shaders");
		AssetDatabase.CreateFolder ("Assets", "Static Assets");




	}
}
