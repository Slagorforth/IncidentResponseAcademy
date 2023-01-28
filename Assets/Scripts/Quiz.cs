using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour {

    
    // Die Dialogbox, die angezeigt wird.
    public GameObject dialogBox;
    // Das Text-Component der Dialogbox, in dem der Text angezeigt wird.
    public Text dialogText, dialogText2, dialogText3, dialogText4, dialogText5;
    // Der Text, der in der Dialogbox angezeigt wird.
    public string dialog, dialog2, dialog3, dialog4, dialog5;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // Diese Methode wird aufgerufen, wenn ein anderes Collision2D-GameObject in den Trigger eintritt.
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Wenn das GameObject, das den Trigger betritt, das Player-Tag hat, wird das "contextOn"-Signal gesendet und die "playerInRange"-Flag wird auf "true" gesetzt.
        if (other.CompareTag("Player"))
        {
            dialogBox.SetActive(true);
            dialogText.text = dialog;
            dialogText2.text = dialog2;
            dialogText3.text = dialog3;
            dialogText4.text = dialog4;
            dialogText5.text = dialog5;
        }
    }

    // Diese Methode wird aufgerufen, wenn ein anderes Collision2D-GameObject den Trigger verlässt.
    private void OnTriggerExit2D(Collider2D other)
    {
        // Wenn das GameObject, das den Trigger verlässt, das Player-Tag hat, wird das "contextOff"-Signal gesendet und die "playerInRange"-Flag wird auf "false" gesetzt.
        // Die Dialogbox wird ebenfalls deaktiviert.
        if (other.CompareTag("Player"))
        {            
            dialogBox.SetActive(false);
        }

    }
}
