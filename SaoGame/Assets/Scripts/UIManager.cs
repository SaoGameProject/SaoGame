using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Tooltip("Mettre les actives que vous voulez dans l'array et puis sur le boutton mettre la fonction Activate ainsi que l'int de l'active (array commence par 0)")]
    [SerializeField] private GameObject[] Activable;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject active in Activable)
        {
            active.SetActive(false);
        }
    }

    public void Activate(int number)
    {
        foreach (GameObject active in Activable)
        {
            active.SetActive(false);
        }
        GameObject ToActive = Activable[number];
        ToActive.SetActive(true);
    }
}
