using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwapImage : MonoBehaviour
{
    [SerializeField] private GameObject[] Images;
    [SerializeField] private GameObject[] Texts;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject active in Images)
        {
            active.SetActive(false);
        }
        foreach (GameObject active in Texts)
        {
            active.SetActive(false);
        }
        GameObject ImageToActive = Images[0];
        ImageToActive.SetActive(true);
        GameObject TextToActive = Texts[0];
        TextToActive.SetActive(true);
    }
    public void Activate(int number)
    {
        foreach (GameObject active in Images)
        {
            active.SetActive(false);
        }
        foreach (GameObject active in Texts)
        {
            active.SetActive(false);
        }
        GameObject ImageToActive = Images[number];
        ImageToActive.SetActive(true);
        GameObject TextToActive = Texts[number];
        TextToActive.SetActive(true);
    }
}
