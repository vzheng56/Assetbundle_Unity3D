using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {

    private string[] _animationNames = {"eat","loop","raise","swim","swimInPlace","idle" };
	// Use this for initialization
	void Start () {
        StartCoroutine(FishSwim());
	}

    IEnumerator FishSwim()
    {
        while (true)
        {
            yield return new WaitForSeconds(4);
            {
                int index = Random.Range(0,5);
                animation.CrossFade(_animationNames[index]);
            }
        }
    }
	// Update is called once per frame
	void Update () {
	

	}
}
