using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {
    // Das Signal, das gesendet wird, wenn der Spieler in die Nähe kommt.
    public Signal contextOn;
    // Das Signal, das gesendet wird, wenn der Spieler die Nähe verlässt.
    public Signal contextOff;
    public GameObject light1, light2, light3, light4;
    public GameObject schalter1, schalter2, schalter3, schalter4;
    public GameObject schalterAus1, schalterAus2, schalterAus3, schalterAus4;
    public GameObject lockedDoor;
    public Sprite newSprite;
    // Eine Flag, die angibt, ob der Spieler in der Nähe ist.
    public bool playerInRange;
    int zaehler = 0; 
    
    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (schalter1.GetComponent<ButtonSwitch>().InRange() && schalter1.activeSelf)
            {
                //Debug.Log("1");
                schalter1.GetComponent<ButtonSwitch>().playerInRange = false;
                schalter1.SetActive(false);
                schalterAus1.SetActive(true);
                LightSwitching();
            }            
            else if (schalter2.GetComponent<ButtonSwitch>().InRange() && schalter2.activeSelf)
            {
                //Debug.Log("2");
                schalter2.GetComponent<ButtonSwitch>().playerInRange = false;
                schalter2.SetActive(false);
                schalterAus2.SetActive(true);
                LightSwitching();
            }
            else if (schalter3.GetComponent<ButtonSwitch>().InRange() && schalter3.activeSelf)
            {
                //Debug.Log("3");
                schalter3.GetComponent<ButtonSwitch>().playerInRange = false;
                schalter3.SetActive(false);
                schalterAus3.SetActive(true);
                LightSwitching();
            }            
            else if (schalter4.GetComponent<ButtonSwitch>().InRange() && schalter4.activeSelf)
            {
                //Debug.Log("4");
                schalter4.GetComponent<ButtonSwitch>().playerInRange = false;
                schalter4.SetActive(false);
                schalterAus4.SetActive(true);
                LightSwitching();
            }
            else if (!schalter1.GetComponent<ButtonSwitch>().InRange() 
                    && !schalter2.GetComponent<ButtonSwitch>().InRange()
                    && !schalter3.GetComponent<ButtonSwitch>().InRange()
                    && !schalter4.GetComponent<ButtonSwitch>().InRange())
            {
                //abfangen falls Spieler Leertaste drückt ohne vor einem Scchalter zu stehen
            }
            else
            {
                //Debug.Log("SwitchElse");
                ResetSwitches();
            }
        }
    }

    private void ResetSwitches()
    {
        zaehler = 0;
        schalter1.SetActive(true);
        schalter2.SetActive(true);
        schalter3.SetActive(true);
        schalter4.SetActive(true);
        schalterAus1.SetActive(false);
        schalterAus2.SetActive(false);
        schalterAus3.SetActive(false);
        schalterAus4.SetActive(false);
        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
        light4.SetActive(false);
    }

    public void LightSwitching()
    {
        zaehler++;
        //Debug.Log("zähler:" + zaehler);
        if (schalterAus3.activeSelf && zaehler == 1)
        {
            light3.SetActive(true);
        }
        else if (schalterAus1.activeSelf && zaehler == 2)
        {
            light1.SetActive(true);
        }
        else if (schalterAus4.activeSelf && zaehler == 3)
        {
            light4.SetActive(true);
        }
        else if (schalterAus2.activeSelf && zaehler == 4)
        {
            light2.SetActive(true);
            lockedDoor.GetComponent<SpriteRenderer>().sprite = newSprite;
            lockedDoor.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            Debug.Log("LightElse");
            ResetSwitches();
        }
    }
}
