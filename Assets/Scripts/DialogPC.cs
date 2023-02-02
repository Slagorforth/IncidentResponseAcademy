using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogPC : Interactable {

    [SerializeField] private GameObject branchingCanvas;
    // Reference to the intermediate dialog value
    [SerializeField] private TextAssetValue dialogValue;
    // Reference to the Pc Dialog
    [SerializeField] private TextAsset myDialog;
    // Notifiation to send to the Canvases to activate and check
    // dialog
    [SerializeField] private Notification branchingDialogNotification;
    // Das Signal, das gesendet wird, wenn der Spieler in die Nähe kommt.
    public Signal contextOn;
    // Das Signal, das gesendet wird, wenn der Spieler die Nähe verlässt.
    public Signal contextOff;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerInRange)
        {
            if (Input.GetButtonDown("Check") && !branchingCanvas.activeSelf)
            {
                dialogValue.value = myDialog;
                branchingDialogNotification.Raise();
            }
        }
	}
    // Diese Methode wird aufgerufen, wenn ein anderes Collision2D-GameObject in den Trigger eintritt.
    override public void OnTriggerEnter2D(Collider2D other)
    {
        // Wenn das GameObject, das den Trigger betritt, das Player-Tag hat, wird das "contextOn"-Signal gesendet und die "playerInRange"-Flag wird auf "true" gesetzt.
        if (other.CompareTag("Player"))
        {
            contextOn.Raise();
            playerInRange = true;
        }
    }

    // Diese Methode wird aufgerufen, wenn ein anderes Collision2D-GameObject den Trigger verlässt.
    override public void OnTriggerExit2D(Collider2D other)
    {
        // Wenn das GameObject, das den Trigger verlässt, das Player-Tag hat, wird das "contextOff"-Signal gesendet und die "playerInRange"-Flag wird auf "false" gesetzt.
        // Die Dialogbox wird ebenfalls deaktiviert.
        if (other.CompareTag("Player"))
        {
            contextOff.Raise();
            playerInRange = false;
        }

    }
}
