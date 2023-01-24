using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

    public TMP_Text scoreText;
    private int score;
    public GameObject lockedDoor;
    public Sprite newSprite;

    void Update()
    {
        scoreText.text = "Score: " + score;
        if(score >= 1000)
        {
            Success();
        }
    }

    public void AddScore()
    {
        score += 100;
    }

    public void Success()
    {
        lockedDoor.GetComponent<SpriteRenderer>().sprite = newSprite;
        lockedDoor.GetComponent<BoxCollider2D>().enabled = false;
    }
}
