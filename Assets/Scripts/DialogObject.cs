using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogObject : MonoBehaviour {

    [SerializeField] private TextMeshProUGUI myText;

	public void Setup(string newDialog)
    {
        myText.text = newDialog;
    }
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
