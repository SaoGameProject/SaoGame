using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Tooltip("Mettre les actives que vous voulez dans l'array et puis sur le boutton mettre la fonction Activate ainsi que l'int de l'active (array commence par 0)")]
    [SerializeField] private GameObject[] Activable;
    [Tooltip("Objet affichable quand on appui sur échap")]
    [SerializeField] private GameObject[] EscapeObj;
    [SerializeField] private bool IsEscape;
    [SerializeField]
    Behaviour[] componentsToDisable;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject active in Activable)
        {
            active.SetActive(false);
        }
        foreach (GameObject active in EscapeObj)
        {
            active.SetActive(false);
        }
        IsEscape = false;
    }
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) && EscapeObj != null)
        {
            if (IsEscape == false)
            {
                ActivateEscapeObj();
                
            }
            else if (IsEscape == true)
            {
                DesactivateEscapeObj();
            }
        }
    }
    //Fonction pour active l'objet en fonction de son nombre dans l'array
    public void Activate(int number)
    {
        foreach (GameObject active in Activable)
        {
            active.SetActive(false);
        }
        GameObject ToActive = Activable[number];
        ToActive.SetActive(true);
    }
    //Fonction pour activer l'obj en fonction de si la touche échap à été pressé
    public void ActivateEscapeObj()
    {
        if (EscapeObj != null)
        {
            foreach (GameObject active in EscapeObj)
            {
                active.SetActive(true);
            }
            DisableComponents();
            IsEscape = true;
            Cursor.visible = true;
		    Cursor.lockState = CursorLockMode.None;
        }
    }
    //Fonction pour désactiver l'obj en fonction de si la touche échap à été pressé
    public void DesactivateEscapeObj()
    {
        if (EscapeObj != null)
        {
            foreach (GameObject active in EscapeObj)
            {
                active.SetActive(false);
            }
            EnableComponents();
            IsEscape = false;
            Cursor.visible = false;
		    Cursor.lockState = CursorLockMode.Locked;
        }
    }
    private void DisableComponents()
    {
        if (componentsToDisable != null)
        {
            // boucle pour désactiver les components des autres joueurs sur notre instance
            for (int i = 0; i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = false;
            }
        }
    }
    private void EnableComponents()
    {
        if (componentsToDisable != null)
        {
            // boucle pour désactiver les components des autres joueurs sur notre instance
            for (int i = 0; i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = true;
            }
        }
    }
}
