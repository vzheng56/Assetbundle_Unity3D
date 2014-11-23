using UnityEngine;
using System.Collections;

public class AssetManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public IEnumerator LoadGameObjectAssets(string path)
    {
        //1. 加载 过程
        WWW assetBunlde = new WWW(path);
        yield return assetBunlde; // 完成 加载后再执行下一步 所以使用 yield 
        //2. 从资源包里面Load 资源
        //Object fish = assetBunlde.assetBundle.Load("Littlefish");
        Object fish = assetBunlde.assetBundle.mainAsset;
        //3. 从内存里面实例化
        GameObject currentFish = Instantiate(fish) as GameObject;
        currentFish.transform.position = Vector3.zero;
        //4. 卸载资源 参数含义
        // false ： 表示 卸载了 加载到 内存的资源包 并不卸载所携带的内容
        // true ： 表示 卸载资源包 和 所关联的所有资源。
        assetBunlde.assetBundle.Unload(false);
    }

    public IEnumerator LoadGameObjects(string path)
    {
        //1. 加载 过程
        WWW assetBunlde = new WWW(path);
        yield return assetBunlde; // 完成 加载后再执行下一步 所以使用 yield 
        //2. 从资源包里面Load 资源
        Object fishNoScript = assetBunlde.assetBundle.Load("LittlefishNoScript");
        Object fishScript = assetBunlde.assetBundle.Load("LittlefishScript");
        //3. 从内存里面实例化
        GameObject currentNoScriptFish = Instantiate(fishNoScript) as GameObject;
        GameObject currentScriptFish = Instantiate(fishScript) as GameObject;
        currentNoScriptFish.transform.position = new Vector3(Random.Range(-1.0f,1.0f), 0, 0);
        currentScriptFish.transform.position = new Vector3(Random.Range(-1.0f, 1.0f), 0, 0);
        //4. 卸载资源 参数含义
        // false ： 表示 卸载了 加载到 内存的资源包 并不卸载所携带的内容
        // true ： 表示 卸载资源包 和 所关联的所有资源。
        assetBunlde.assetBundle.Unload(false);
    }

    public IEnumerator LoadGameScene(string path)
    {
        //1. 加载 过程
        WWW assetBunlde = new WWW(path);
        yield return assetBunlde; // 完成 加载后再执行下一步 所以使用 yield 
        //2. 从资源包里面Load 资源

        AssetBundle sceneBunlde = assetBunlde.assetBundle;
        Application.LoadLevel("LoadedScene");
    }

}
