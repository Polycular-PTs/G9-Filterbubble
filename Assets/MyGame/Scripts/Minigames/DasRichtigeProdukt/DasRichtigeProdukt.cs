using UnityEngine;
using UnityEngine.UI;

public class DasRichtigeProdukt : MonoBehaviour
{
    public Image[] bilder;         // Drei Image-Objekte Array um Bilder einzusetzen
    public int richtigesBildIndex; // Index des richtigen Bildes (0, 1 oder 2)
    public Text feedbackText;      // Text-Objekt Feedback

    void Start()
    {
        // Klick-Ereignisse hinzufügen
        for (int i = 0; i < bilder.Length; i++)
        {
            int index = i; 
            bilder[i].GetComponent<Button>().onClick.AddListener(() => BildGeklickt(index));
        }
    }

    void BildGeklickt(int index)
    {
        //Feedback 
        if (index == richtigesBildIndex)
        {
            feedbackText.text = "Richtig!";
        }
        else
        {
            feedbackText.text = "Falsch, versuch's nochmal!";
        }
    }
}