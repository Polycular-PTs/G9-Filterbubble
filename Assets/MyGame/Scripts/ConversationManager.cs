using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour
{
    public TextMeshProUGUI meinDialog;
    public TextMeshProUGUI nameDisplay;
    public RawImage characterDisplay;

    public Conversation con;
    public int indexAnswers;

    public GameObject Option1;
    public GameObject Option2;

    private void Start()
    {
        meinDialog.text = con.dialog[indexAnswers];
        nameDisplay.text = con.names[indexAnswers];
        characterDisplay.texture = con.characterImage[indexAnswers];
        Option1.SetActive(false);
        Option2.SetActive(false);
    }

    public void NextDialog()
    {
        //Continue Dialog
        if (indexAnswers + 1 < con.dialog.Length)
        {
            indexAnswers = indexAnswers + 1;
            meinDialog.text = con.dialog[indexAnswers];
            nameDisplay.text = con.names[indexAnswers];
            characterDisplay.texture = con.characterImage[indexAnswers];
        }
        //Load Answers
        if (con.dialog.Length == indexAnswers + 1)
        {
            Option1.SetActive(true);
            Option1.GetComponentInChildren<TextMeshProUGUI>().text = con.decisionAtext;
            Option2.SetActive(true);
            Option2.GetComponentInChildren<TextMeshProUGUI>().text = con.decisionBtext;
        }
    }

    public void NextState(int decisionIndex)
    {
        if (decisionIndex == 1)
        {
            con = con.decisionA;
        }
        if (decisionIndex == 2)
        {
            con = con.decisionB;
        }
        indexAnswers = 0;
        meinDialog.text = con.dialog[indexAnswers];
        nameDisplay.text = con.names[indexAnswers];
        characterDisplay.texture = con.characterImage[indexAnswers];
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            NextDialog();
        }
    }
}
