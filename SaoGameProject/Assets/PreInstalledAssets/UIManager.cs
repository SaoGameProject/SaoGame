using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Active de chaque boutton")]
    [SerializeField] private GameObject ActiveMe;
    [SerializeField] private GameObject ActiveFriends;
    [SerializeField] private GameObject ActiveMessage;
    [SerializeField] private GameObject ActiveLocation;
    [SerializeField] private GameObject ActiveSettings;


    // Start is called before the first frame update
    void Start()
    {
        ActiveMe.SetActive(false);
        ActiveFriends.SetActive(false);
        ActiveMessage.SetActive(false);
        ActiveLocation.SetActive(false);
        ActiveSettings.SetActive(false);
    }

    //Active button pour Me
    public void Me()
    {
        ActiveMe.SetActive(true);
        ActiveFriends.SetActive(false);
        ActiveMessage.SetActive(false);
        ActiveLocation.SetActive(false);
        ActiveSettings.SetActive(false);
    }
    //Active button pour Friends
    public void Friends()
    {
        ActiveMe.SetActive(false);
        ActiveFriends.SetActive(true);
        ActiveMessage.SetActive(false);
        ActiveLocation.SetActive(false);
        ActiveSettings.SetActive(false);
    }
    //Active button pour Message
    public void Message()
    {
        ActiveMe.SetActive(false);
        ActiveFriends.SetActive(false);
        ActiveMessage.SetActive(true);
        ActiveLocation.SetActive(false);
        ActiveSettings.SetActive(false);
    }
    //Active button pour Location
    public void Location()
    {
        ActiveMe.SetActive(false);
        ActiveFriends.SetActive(false);
        ActiveMessage.SetActive(false);
        ActiveLocation.SetActive(true);
        ActiveSettings.SetActive(false);
    }
    //Active button pour Settings
    public void Settings()
    {
        ActiveMe.SetActive(false);
        ActiveFriends.SetActive(false);
        ActiveMessage.SetActive(false);
        ActiveLocation.SetActive(false);
        ActiveSettings.SetActive(true);
    }
}
