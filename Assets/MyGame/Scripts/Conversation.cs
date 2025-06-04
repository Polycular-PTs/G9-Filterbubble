using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation : MonoBehaviour
{
    public string[] dialog;
    public string[] names;
    public Texture[] characterImage;

    public Conversation decisionA;
    public Conversation decisionB;
    public string decisionAtext;
    public string decisionBtext;

    [Header("Soll etwas aktivier/deaktiviert werden")]
    public GameObject toActivate;
    public GameObject toDeactivate;
}
