using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoScroll : MonoBehaviour {

    [SerializeField] public ScrollRect comScroll;
    IEnumerator ForceScrollDown()
    {
        // Wait for end of frame AND force update all canvases before setting to bottom.

        yield return new WaitForEndOfFrame();
        Canvas.ForceUpdateCanvases();
        comScroll.verticalNormalizedPosition = 0f;
        Canvas.ForceUpdateCanvases();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
