using UnityEngine;
using System.Collections;

public class MyButton : MonoBehaviour
{

    public Texture2D[] ButtonTextures;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        if (ButtonTextures[1])
            renderer.material.mainTexture = ButtonTextures[1];
    }

    void OnMouseExit()
    {
        if (ButtonTextures[0])
            renderer.material.mainTexture = ButtonTextures[0];
    }

    void OnMouseDown()
    {
        Debug.Log("AAAA");
        if (ButtonTextures[2])
            renderer.material.mainTexture = ButtonTextures[2];
    }

    void OnMouseUp()
    {
        if (ButtonTextures[0])
            renderer.material.mainTexture = ButtonTextures[0];
        //并且执行其他的方法： 比如 进入下载状态经 准备打开其他场景
        switch (gameObject.name)
        {
            case "Button_A":
                LoadSceneA();
                break;
            case "Button_B":
                LoadSceneB();
                break;
            default:
                return;
        }
    }

    void LoadSceneA()
    {
        string assetPath = "file://" + Application.streamingAssetsPath + "/" + "LoadedSceneA.unity3d";
        StartCoroutine(AssetManager.LoadGameScene(assetPath, "LoadedScene_A"));

    }
    void LoadSceneB()
    {
        string assetPath = "file://" + Application.streamingAssetsPath + "/" + "LoadedSceneB.unity3d";
        StartCoroutine(AssetManager.LoadGameScene(assetPath, "LoadedScene_B"));
    }
}
