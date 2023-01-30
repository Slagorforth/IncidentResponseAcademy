using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingTip : MonoBehaviour {

    // Das Signal, das gesendet wird, wenn der Spieler in die Nähe kommt.
    public Signal contextOn;
    // Das Signal, das gesendet wird, wenn der Spieler die Nähe verlässt.
    public Signal contextOff;
    // Eine Flag, die angibt, ob der Spieler in der Nähe ist.
    public bool playerInRange;
    public GameObject schalterAus;
    public GameObject schalterAn;
    public GameObject buch;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if (schalterAn.activeSelf)
            {
                schalterAn.SetActive(false);
                schalterAus.SetActive(true);
                buch.SetActive(true);
            }
            else
            {
                schalterAus.SetActive(false);
                buch.SetActive(false);
                schalterAn.SetActive(true);
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        // Is it the player?
        if (other.CompareTag("Player"))
        {
            contextOn.Raise();
            playerInRange = true;
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            contextOff.Raise();
            playerInRange = false;
        }

    }
}
