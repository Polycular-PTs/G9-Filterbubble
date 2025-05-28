using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Events : MonoBehaviour
{

    public GameObject fadeScreenIn;
    public GameObject charKasumiD;
    public GameObject charKasumiS;
    public GameObject charHaruka;
    public GameObject textBox;

    [SerializeField] AudioSource girlSigh;
    [SerializeField] AudioSource girlGasp;

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        charKasumiD.SetActive(true);
        charKasumiS.SetActive(true);
        yield return new WaitForSeconds(2);
        girlSigh.Play();
        charKasumiD.SetActive(false);
        // this is where the tutorial puts the Text Function
        textBox.SetActive(true);
        yield return new WaitForSeconds(2);
        charHaruka.SetActive(true);
        girlGasp.Play();
    }
}
