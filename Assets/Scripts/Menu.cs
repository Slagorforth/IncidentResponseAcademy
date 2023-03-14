using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MenuCanvas, ControlCanvas, CreditCanvas;
    public GameObject player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !MenuCanvas.activeSelf)
        {
            MenuCanvas.SetActive(true);
            player.GetComponent<PlayerMovement>().speed = 0f;
        }
    }

    public void Resume()
    {
        MenuCanvas.SetActive(false);
        player.GetComponent<PlayerMovement>().speed = 5f;
    }

    public void QuitToDesktop()
    {
        Application.Quit();
    }

    public void ShowCredits()
    {
        MenuCanvas.SetActive(false);
        CreditCanvas.SetActive(true);
    }

    public void ShowControls()
    {
        MenuCanvas.SetActive(false);
        ControlCanvas.SetActive(true);
    }

    public void Back()
    {
        CreditCanvas.SetActive(false);
        ControlCanvas.SetActive(false);
        MenuCanvas.SetActive(true);
    }
}