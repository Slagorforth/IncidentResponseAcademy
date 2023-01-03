using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextClue : Interactable
{
    [SerializeField] private SpriteRenderer mySprite;
    [SerializeField] private bool clueActive = false;
    [SerializeField] private GameObject fragezeichen;


    public void ChangeClue()
    {
        if (playerInRange)
        {
            clueActive = !clueActive;
            //mySprite.enabled = clueActive;
            fragezeichen.SetActive(true);
        }

        if(clueActive == true && !playerInRange)
        {
            clueActive = !clueActive;
            fragezeichen.SetActive(false);
        }
        
    }



}