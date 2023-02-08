using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour {

    public TMP_Text scoreText;
    private int score;
    public GameObject lockedDoor;
    public GameObject teleporter;
    public Sprite newSprite;
    public GameObject imageGreen, imageRed;
    public float displayTime = 5f;
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
        Right();
    }

    public void Success()
    {
        lockedDoor.GetComponent<SpriteRenderer>().sprite = newSprite;
        lockedDoor.GetComponent<BoxCollider2D>().enabled = false;
        teleporter.SetActive(true);
    }
    public void Right()
    {
        imageGreen.gameObject.SetActive(true);
        StartCoroutine(DeactivateAfterTime());
    }

    public void False()
    {
        imageRed.gameObject.SetActive(true);
        StartCoroutine(DeactivateAfterTime());
    }

    IEnumerator DeactivateAfterTime()
    {
        yield return new WaitForSeconds(displayTime);
        imageGreen.gameObject.SetActive(false);
        imageRed.gameObject.SetActive(false);
    }
}
