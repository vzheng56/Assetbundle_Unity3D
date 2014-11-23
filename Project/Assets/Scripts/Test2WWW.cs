using UnityEngine;
using System.Collections;

public class Test2WWW : MonoBehaviour {

    public string url = "http://g.hiphotos.baidu.com/image/pic/item/3801213fb80e7bec5aab59292d2eb9389a506b80.jpg";

    IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;
        renderer.material.mainTexture = www.texture;
    }
}
