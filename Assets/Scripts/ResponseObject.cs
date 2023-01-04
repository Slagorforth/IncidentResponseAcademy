using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResponseObject : MonoBehaviour {

    [SerializeField] private TextMeshProUGUI myText;
    private int choiceValue;

    public void Setup(string newDialog, int myChoice)
    {
        myText.text = newDialog;
        choiceValue = myChoice;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
