using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour {

    public GameObject schalter1, schalter2, schalter3, schalter4;

    public void TurnOff()
    {
        schalter1.GetComponent<BoxCollider2D>().isTrigger = false;
        schalter2.GetComponent<BoxCollider2D>().isTrigger = false;
        schalter3.GetComponent<BoxCollider2D>().isTrigger = false;
        schalter4.GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
