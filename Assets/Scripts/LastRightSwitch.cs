using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastRightSwitch : MonoBehaviour {

    public bool active; //Deklariert eine Variable active, die den Zustand des Schalters speichert.
    public BoolValue storedValue; //Deklariert eine Referenz auf ein BoolValue-Objekt, das den gespeicherten Wert des Schalters enthält.
    public Sprite activeSprite; //Deklariert eine Referenz auf ein aktives Sprite, das verwendet wird, wenn der Schalter aktiviert ist.
    private SpriteRenderer mySprite; //Deklariert eine private Referenz auf den SpriteRenderer des Schalters.
    public GameObject score;
    public GameObject controller;
    public GameObject signal;
    public float displayTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>(); //Holt den spriteRenderer-Komponenten des Schalters
        active = storedValue.RuntimeValue; //Setzt den aktiven Zustand des Schalters auf den gespeicherten Wert des BoolValue-Objekts.
        if (active)  //Überprüft, ob der Schalter aktiviert ist.
        {
            ActivateSwitch();
        }
    }

    public void ActivateSwitch()
    {
        active = true; //Setzt den aktiven Zustand des Schalters auf "wahr"
        storedValue.RuntimeValue = active; //Setzt den gespeicherten Wert des BoolValue-Objekts auf den aktiven Zustand des Schalters.
        mySprite.sprite = activeSprite; //Ändert das sprite des Schalters auf das aktive sprite.
        score.GetComponent<ScoreManager>().AddScore();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        // Is it the player?
        if (other.CompareTag("Player"))
        {
            ActivateSwitch();
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            controller.GetComponent<SwitchController>().TurnOff();
            signal.SetActive(true);
            StartCoroutine(DeactivateAfterTime());
        }
    }

    IEnumerator DeactivateAfterTime()
    {
        yield return new WaitForSeconds(displayTime);
        signal.SetActive(false);
    }
}
