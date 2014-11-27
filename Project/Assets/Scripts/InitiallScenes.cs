using UnityEngine;
using System.Collections;

public class InitiallScenes : MonoBehaviour {

    //public AssetManager CurrentAssetManager;
	// Use this for initialization
	void Start () {

       // Application.LoadLevel(1);
        //string assetPath = "file://" + Application.streamingAssetsPath + "/" + "fish.unity3d";
        //string assetPathAni = "file://" + Application.streamingAssetsPath + "/" + "animationfish.unity3d";

        //Debug.Log(assetPath);
        //StartCoroutine(CurrentAssetManager.LoadGameObjectAssets(assetPath));
        //StartCoroutine(CurrentAssetManager.LoadGameObjectAssets(assetPathAni));

        string assetPath = "file://" + Application.streamingAssetsPath + "/" + "myNewScene.unity3d";
        StartCoroutine(AssetManager.LoadGameScene(assetPath, "LoadedScene_A"));


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
