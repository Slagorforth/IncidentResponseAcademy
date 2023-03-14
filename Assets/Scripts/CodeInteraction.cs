using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeInteraction : MonoBehaviour {

    // Das Signal, das gesendet wird, wenn der Spieler in die Nähe kommt.
    public Signal contextOn;
    // Das Signal, das gesendet wird, wenn der Spieler die Nähe verlässt.
    public Signal contextOff;
    public InputField codeInput;
    public GameObject lockedDoor;
    public Sprite newSprite;
    private string correctCode = "254";
    public bool playerInRange;
    private bool isInputActive = false;
    [SerializeField] private GameObject defaultCanvas, wrongCodeCanvas, rightCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.Space))
        {
            if (!isInputActive) 
            {
                codeInput.gameObject.SetActive(true);
                codeInput.ActivateInputField();
                isInputActive = true;
            }
            else if (isInputActive && Input.GetKeyDown(KeyCode.Space))
            {
                CheckCode(codeInput.text);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
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
            codeInput.gameObject.SetActive(false);
            isInputActive = false;
        }
    }

    void CheckCode(string input)
    {
        if (input == correctCode)
        {
            lockedDoor.GetComponent<SpriteRenderer>().sprite = newSprite;
            lockedDoor.GetComponent<BoxCollider2D>().enabled = false;
            defaultCanvas.SetActive(false);
            wrongCodeCanvas.SetActive(false);
            rightCanvas.SetActive(true);
        }
        else
        {
            defaultCanvas.SetActive(false);
            wrongCodeCanvas.SetActive(true);
        }
    }
}