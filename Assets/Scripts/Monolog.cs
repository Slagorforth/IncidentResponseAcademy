using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Monolog : MonoBehaviour
{

    // Die Dialogbox, die angezeigt wird.
    public GameObject dialogBox;
    // Das Text-Component der Dialogbox, in dem der Text angezeigt wird.
    public Text dialogText;
    // Der Text, der in der Dialogbox angezeigt wird.
    public string dialog;
 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogBox.SetActive(true);
            dialogText.text = dialog;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {            
            dialogBox.SetActive(false);
        }
    }
}
