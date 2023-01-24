using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseSwitch : MonoBehaviour
{
    public bool active;
    public BoolValue storedValue;
    public Sprite activeSprite;
    private SpriteRenderer mySprite;
    public Door thisDoor; //Deklariert eine Referenz auf die Tür, die geöffnet werden soll, wenn der Schalter aktiviert wird.

    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
        active = storedValue.RuntimeValue;
        if (active)
        {
            ActivateSwitch();
        }
    }

    public void ActivateSwitch()
    {
        active = true;
        storedValue.RuntimeValue = active;
        thisDoor.Open();
        mySprite.sprite = activeSprite;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        // Is it the player?
        if (other.CompareTag("Player"))
        {
            ActivateSwitch();
        }
    }
}