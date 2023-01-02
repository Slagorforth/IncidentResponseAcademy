using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogPC : Interactable {

    // Reference to the intermediate dialog value
    [SerializeField] private TextAssetValue dialogValue;
    // Reference to the Pc Dialog
    [SerializeField] private TextAsset myDialog;
    // Notifiation to send to the Canvases to activate and check
    // dialog
    [SerializeField] private Notification branchingDialogNotification;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerInRange)
        {
            if (Input.GetButtonDown("Check"))
            {
                dialogValue.value = myDialog;
                branchingDialogNotification.Raise();
            }
        }
	}
}
