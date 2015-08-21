using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

public class folderStructure : MonoBehaviour {

	[MenuItem("Tool Creation/Create Folder")]
	[MenuItem("Tool Creation 2/Create Folder 2")]
	public static void CreateFolder()
	{
		//Debug.Log ("Creating a folder!");
		AssetDatabase.CreateFolder ("Assets", "Materials");
		AssetDatabase.CreateFolder ("Assets", "Textures");
		AssetDatabase.CreateFolder ("Assets", "Prefabs");
		AssetDatabase.CreateFolder ("Assets", "Scripts");
		AssetDatabase.CreateFolder ("Assets", "Scenes");
		AssetDatabase.CreateFolder ("Assets", "Animations");
		AssetDatabase.CreateFolder ("Assets/Animations", "AnimationControllers");

		System.IO.File.WriteAllText (Application.dataPath + "/Materials", "Materials: This folder is for storing materials.");
		System.IO.File.WriteAllText (Application.dataPath + "/Textures", "Textures: This folder is for storing materials.");
		System.IO.File.WriteAllText (Application.dataPath + "/Prefabs", "Prefabs: This folder is for storing materials.");
		System.IO.File.WriteAllText (Application.dataPath + "/Scripts", "Scripts: This folder is for storing materials.");
		System.IO.File.WriteAllText (Application.dataPath + "/Scenes", "Scenes: This folder is for storing materials.");
		System.IO.File.WriteAllText (Application.dataPath + "/Animations", "Animations: This folder is for storing materials.");
		System.IO.File.WriteAllText (Application.dataPath + "/Animations/AnimationControllers", 
		                             "AnimationControllers: This folder is for storing materials.");
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
