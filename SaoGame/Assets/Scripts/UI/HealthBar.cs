using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public PlayerHealth playerHealth;


    private void Awake()
    {
       
    }

    private void Update()
    {
        float healthConverter = playerHealth.currentHealth / 100;
        Debug.Log(healthConverter);

        healthBar.fillAmount = healthConverter; 
    }
}
