using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;


public class BranchingDialogController : MonoBehaviour {

    [SerializeField] private GameObject branchingCanvas;
    [SerializeField] private GameObject dialogPrefab;
    [SerializeField] private GameObject choicePrefab;
    [SerializeField] private TextAssetValue dialogValue;
    [SerializeField] private Story myStory;
    [SerializeField] private GameObject dialogHolder;
    [SerializeField] private GameObject choiceHolder;
    [SerializeField] public ScrollRect comScroll;
    public GameObject player;
    


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && branchingCanvas.activeSelf)
        {
            DisableCanvas();
        }
    }

    public void EnableCanvas()
    {
        branchingCanvas.SetActive(true);
        SetStory();
        RefreshView();
        player.GetComponent<PlayerMovement>().speed = 0f;        
    }

    public void DisableCanvas()
    {
        ResetFields();
        branchingCanvas.SetActive(false);
        player.GetComponent<PlayerMovement>().speed = 5f;
    }

    public void SetStory()
    {
        if (dialogValue.value)
        {
            myStory = new Story(dialogValue.value.text);
        }
        else
        {
            Debug.Log("Something went wrong  with the story setup");
        }
    }

    public void RefreshView()
    {
        while (myStory.canContinue)
        {
            MakeNewDialog(myStory.Continue());
            StartCoroutine(ForceScrollDown());
        }
        if(myStory.currentChoices.Count > 0)
        {
            MakeNewChoices();
        }
        else
        {
            DisableCanvas();
        }
    }

    void MakeNewDialog(string newDialog)
    {
        DialogObject newDialogObject = Instantiate(dialogPrefab, dialogHolder.transform).GetComponent<DialogObject>();
        newDialogObject.Setup(newDialog);
    }

    void MakeNewResponse(string newDialog, int choiceValue)
    {
        ResponseObject newResponseObject = Instantiate(choicePrefab, choiceHolder.transform).GetComponent<ResponseObject>();
        newResponseObject.Setup(newDialog, choiceValue);
        Button responseButton = newResponseObject.gameObject.GetComponent<Button>();
        if (responseButton)
        {
            responseButton.onClick.AddListener(delegate { ChooseChoice(choiceValue); });
        }
    }

    void MakeNewChoices()
    {
        for (int i = 0; i < choiceHolder.transform.childCount; i++)
        {
            Destroy(choiceHolder.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < myStory.currentChoices.Count; i++)
        {
            MakeNewResponse(myStory.currentChoices[i].text, i);
        }
    }

    void ChooseChoice(int choice)
    {
        myStory.ChooseChoiceIndex(choice);
        RefreshView();
    }

    void ResetFields()
    {
        for (int i = 0; i < dialogHolder.transform.childCount; i++)
        {
            Destroy(dialogHolder.transform.GetChild(i).gameObject);
        }
    }


    IEnumerator ForceScrollDown()
    {
        // Wait for end of frame AND force update all canvases before setting to bottom.

        yield return new WaitForEndOfFrame();
        Canvas.ForceUpdateCanvases();
        comScroll.verticalNormalizedPosition = 0f;
        Canvas.ForceUpdateCanvases();
    }
}
