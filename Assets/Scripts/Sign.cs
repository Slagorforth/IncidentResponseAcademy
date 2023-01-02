using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Diese Klasse repräsentiert ein Schild - ein GameObject, das eine Dialogbox mit Text anzeigt, wenn der Spieler in der Nähe ist und auf die Leertaste drückt.
// Sie sendet auch Signale, wenn der Spieler in die Nähe kommt oder sie verlässt.
public class Sign : MonoBehaviour
{

    // Das Signal, das gesendet wird, wenn der Spieler in die Nähe kommt.
    public Signal contextOn;
    // Das Signal, das gesendet wird, wenn der Spieler die Nähe verlässt.
    public Signal contextOff;
    // Die Dialogbox, die angezeigt wird.
    public GameObject dialogBox;
    // Das Text-Component der Dialogbox, in dem der Text angezeigt wird.
    public Text dialogText;
    // Der Text, der in der Dialogbox angezeigt wird.
    public string dialog;
    // Eine Flag, die angibt, ob der Spieler in der Nähe ist.
    public bool playerInRange;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Wenn der Spieler die Leertaste drückt und in der Nähe ist, wird die Dialogbox aktiviert oder deaktiviert.
        // Der Text wird ebenfalls geändert, wenn die Dialogbox aktiviert wird.
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }

    // Diese Methode wird aufgerufen, wenn ein anderes Collision2D-GameObject in den Trigger eintritt.
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Wenn das GameObject, das den Trigger betritt, das Player-Tag hat, wird das "contextOn"-Signal gesendet und die "playerInRange"-Flag wird auf "true" gesetzt.
        if (other.CompareTag("Player"))
        {
            contextOn.Raise();
            playerInRange = true;
        }
    }

    // Diese Methode wird aufgerufen, wenn ein anderes Collision2D-GameObject den Trigger verlässt.
    private void OnTriggerExit2D(Collider2D other)
    {
        // Wenn das GameObject, das den Trigger verlässt, das Player-Tag hat, wird das "contextOff"-Signal gesendet und die "playerInRange"-Flag wird auf "false" gesetzt.
        // Die Dialogbox wird ebenfalls deaktiviert.
        if (other.CompareTag("Player"))
        {
            contextOff.Raise();
            playerInRange = false;
            dialogBox.SetActive(false);
        }

    }
}
