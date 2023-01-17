using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSwitch : MonoBehaviour {

    // Das Signal, das gesendet wird, wenn der Spieler in die Nähe kommt.
    public Signal contextOn;
    // Das Signal, das gesendet wird, wenn der Spieler die Nähe verlässt.
    public Signal contextOff;
    // Eine Flag, die angibt, ob der Spieler in der Nähe ist.
    public bool playerInRange;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
        
    }

    public bool InRange()
    {
        return playerInRange;
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

/*Bei Drücken der Leertaste -> Schalter springt um
Bei richtigem Schalter -> Licht geht an sonst -> alle Lichter aus
Wenn alle Lichter an -> Open Door*/