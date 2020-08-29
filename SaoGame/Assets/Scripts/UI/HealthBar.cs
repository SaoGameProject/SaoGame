using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public TextMeshProUGUI healthText;
    public GameObject Parent;

    private static int playerHealth;

    private void Update()
    {
        float percentageHP = ((PlayerHealth.currentHealth * 100) / Parent.GetComponent<PlayerHealth>().maxHealth) / 100;
        healthBar.fillAmount = percentageHP;
        healthText.text = PlayerHealth.currentHealth + "/" + Parent.GetComponent<PlayerHealth>().maxHealth;
    }
}