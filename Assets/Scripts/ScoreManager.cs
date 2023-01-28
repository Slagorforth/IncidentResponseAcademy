using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour {

    public TMP_Text scoreText;
    private int score;
    public GameObject lockedDoor;
    public Sprite newSprite;
    public Image image, image2;
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
    }
    public void Right()
    {
        image.gameObject.SetActive(true);
        StartCoroutine(DeactivateAfterTime());
    }

    public void False()
    {
        image2.gameObject.SetActive(true);
        StartCoroutine(DeactivateAfterTime());
    }

    IEnumerator DeactivateAfterTime()
    {
        yield return new WaitForSeconds(displayTime);
        image.gameObject.SetActive(false);
        image2.gameObject.SetActive(false);
    }
}
