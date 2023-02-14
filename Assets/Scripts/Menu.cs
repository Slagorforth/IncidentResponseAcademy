using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !menu.activeSelf)
        {
            menu.SetActive(true);
            player.GetComponent<PlayerMovement>().speed = 0f;
        }
    }

    public void Resume()
    {
        menu.SetActive(false);
        player.GetComponent<PlayerMovement>().speed = 5f;
    }

    public void QuitToDesktop()
    {
        Application.Quit();
    }
}