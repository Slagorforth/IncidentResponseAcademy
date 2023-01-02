using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Diese Klasse repräsentiert einen "ContextClue" - ein GameObject, das aktiviert oder deaktiviert werden kann.
public class ContextClue : MonoBehaviour
{

    // Das GameObject, das der ContextClue ist.
    public GameObject contextClue;

    // Diese Methode aktiviert den ContextClue.
    public void Enable()
    {
        contextClue.SetActive(true);
    }

    // Diese Methode deaktiviert den ContextClue.
    public void Disable()
    {
        contextClue.SetActive(false);
    }
}