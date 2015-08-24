using UnityEngine;
using System.Collections;
using UnityEditor;

public class CreateFolders : MonoBehaviour {

	[MenuItem("Tool Creation/Create folders")]
	public static void Createfolders()
	{
		// Create string constants to hold the paths to the parent folders in the Assets folder structure.
		const string DynamicAssetsPath = "Assets/DynamicAssets";
		const string DynamicAssetsResourcesPath = DynamicAssetsPath + "/Resources";
		const string DynamicAssetsResourcesAnimationsPath = DynamicAssetsResourcesPath + "/Animations";
		const string DynamicAssetsResourcesModelsPath = DynamicAssetsResourcesPath + "/Models";
		const string DynamicAssetsResourcesPrefabsPath = DynamicAssetsResourcesPath + "/Prefabs";
		const string DynamicAssetsResourcesSoundsPath = DynamicAssetsResourcesPath + "/Sounds";
		const string DynamicAssetsResourcesSoundsMusicPath = DynamicAssetsResourcesSoundsPath + "/Music";
		const string DynamicAssetsResourcesSoundsSFXPath = DynamicAssetsResourcesSoundsPath + "/SFX";
		const string DynamicAssetsResourcesTexturesPath = DynamicAssetsResourcesPath + "/Textures";
		const string ScriptsPath = "Assets/Scripts";
		const string StaticAssetsPath = "Assets/StaticAssets";
		const string StaticAssetsAnimationsPath = StaticAssetsPath + "/Animations";
		const string StaticAssetsModelsPath = StaticAssetsPath + "/Models";
		const string StaticAssetsPrefabsPath = StaticAssetsPath + "/Prefabs";
		const string StaticAssetsSoundsPath = StaticAssetsPath + "/Sounds";
		const string StaticAssetsSoundsMusicPath = StaticAssetsSoundsPath + "/Music";
		const string StaticAssetsSoundsSFXPath = StaticAssetsSoundsPath + "/SFX";
		const string StaticAssetsTexturesPath = StaticAssetsPath + "/Textures";


		// Create the desired folder structure using the path string constants defined above.
		AssetDatabase.CreateFolder("Assets", "DynamicAssets");
		AssetDatabase.CreateFolder(DynamicAssetsPath, "Resources");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesPath, "Animations");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesAnimationsPath, "Sources");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesPath, "AnimationControllers");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesPath, "Effects");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesPath, "Models");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesModelsPath, "Character");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesModelsPath, "Environment");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesPath, "Prefabs");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesPrefabsPath, "Common");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesPath, "Sounds");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesSoundsPath, "Music");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesSoundsMusicPath, "Common");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesSoundsPath, "SFX");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesSoundsSFXPath, "Common");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesPath, "Textures");
		AssetDatabase.CreateFolder(DynamicAssetsResourcesTexturesPath, "Common");
		AssetDatabase.CreateFolder("Assets", "Extensions");
		AssetDatabase.CreateFolder("Assets", "Gizmos");
		AssetDatabase.CreateFolder("Assets", "Plugins");
		AssetDatabase.CreateFolder("Assets", "Scripts");
		AssetDatabase.CreateFolder(ScriptsPath, "Common");
		AssetDatabase.CreateFolder("Assets", "Shaders");
		AssetDatabase.CreateFolder("Assets", "StaticAssets");
		AssetDatabase.CreateFolder(StaticAssetsPath, "Animations");
		AssetDatabase.CreateFolder(StaticAssetsAnimationsPath, "Sources");
		AssetDatabase.CreateFolder(StaticAssetsPath, "AnimationControllers");
		AssetDatabase.CreateFolder(StaticAssetsPath, "Effects");
		AssetDatabase.CreateFolder(StaticAssetsPath, "Models");
		AssetDatabase.CreateFolder(StaticAssetsModelsPath, "Character");
		AssetDatabase.CreateFolder(StaticAssetsModelsPath, "Environment");
		AssetDatabase.CreateFolder(StaticAssetsPath, "Prefabs");
		AssetDatabase.CreateFolder(StaticAssetsPrefabsPath, "Common");
		AssetDatabase.CreateFolder(StaticAssetsPath, "Scenes");
		AssetDatabase.CreateFolder(StaticAssetsPath, "Sounds");
		AssetDatabase.CreateFolder(StaticAssetsSoundsPath, "Music");
		AssetDatabase.CreateFolder(StaticAssetsSoundsMusicPath, "Common");
		AssetDatabase.CreateFolder(StaticAssetsSoundsPath, "SFX");
		AssetDatabase.CreateFolder(StaticAssetsSoundsSFXPath, "Common");
		AssetDatabase.CreateFolder(StaticAssetsPath, "Textures");
		AssetDatabase.CreateFolder(StaticAssetsTexturesPath, "Common");
		AssetDatabase.CreateFolder("Assets", "Testing");

		// Create a file named "folderStructure.txt" in the Assets/DynamicAssets/Resources folder.
		System.IO.File.WriteAllText(Application.dataPath + "/DynamicAssets/Resources/folderStructure.txt",
		  "This folder is for storing assets that are loaded into the game via Resources.Load().");
		
		// Create a file named "folderStructure.txt" in the Assets/Editor folder.
		System.IO.File.WriteAllText(Application.dataPath + "/Editor/folderStructure.txt",
		                            "This folder is for storing Editor scripts.");
		
		// Create a file named "folderStructure.txt" in the Assets/Extensions folder.
		System.IO.File.WriteAllText(Application.dataPath + "/Extensions/folderStructure.txt",
		                            "This folder is for storing third party asset packages.");
		
		// Create a file named "folderStructure.txt" in the Assets/Gizmos folder.
		System.IO.File.WriteAllText(Application.dataPath + "/Gizmos/folderStructure.txt",
		                            "This folder is for storing gizmo scripts.");
		
		// Create a file named "folderStructure.txt" in the Assets/Plugins folder.
		System.IO.File.WriteAllText(Application.dataPath + "/Plugins/folderStructure.txt",
		                            "This folder is for storing plugin scripts.");
		
		// Create a file named "folderStructure.txt" in Assets/Scripts folder.
		System.IO.File.WriteAllText(Application.dataPath + "/Scripts/folderStructure.txt",
		                            "This folder is for storing all other scripts.");
		
		// Create a file named "folderStructure.txt" in Assets/Shaders folder.
		System.IO.File.WriteAllText(Application.dataPath + "/Shaders/folderStructure.txt",
		                            "This folder is for storing shader scripts.");
		
		// Create a file named "folderStructure.txt" in Assets/StaticAssets folder.
		System.IO.File.WriteAllText(Application.dataPath + "/StaticAssets/folderStructure.txt",
			"This folder is for storing all remaining assets (including scenes) that are not loaded into the game at runtime.");
		
		// Create a file named "folderStructure.txt" in Assets/Testing folder.
		System.IO.File.WriteAllText(Application.dataPath + "/Testing/folderStructure.txt",
		                            "This folder is for storing scripts and other files used in testing.");

		// Refresh the project structure to commit all changes.
		AssetDatabase.Refresh();
	}  // end method Createfolders()
}  // end class CreateFolders
