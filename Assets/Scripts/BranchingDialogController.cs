using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchingDialogController : MonoBehaviour {

    [SerializeField] private GameObject branchingCanvas;
    [SerializeField] private GameObject dialogPrefab;
    [SerializeField] private GameObject choicePrefab;
    [SerializeField] private TextAssetValue dialogValue;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EnableCanvas()
    {
        branchingCanvas.SetActive(true);
    }
}
