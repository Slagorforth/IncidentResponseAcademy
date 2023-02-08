using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image : MonoBehaviour {

    // Das Signal, das gesendet wird, wenn der Spieler in die Nähe kommt.
    public Signal contextOn;
    // Das Signal, das gesendet wird, wenn der Spieler die Nähe verlässt.
    public Signal contextOff;
    // Das Image, das angezeigt wird.
    public GameObject image;
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
            if (image.activeSelf)
            {
                image.SetActive(false);
            }
            else
            {
                image.SetActive(true);                
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
            image.SetActive(false);
        }

    }
}
