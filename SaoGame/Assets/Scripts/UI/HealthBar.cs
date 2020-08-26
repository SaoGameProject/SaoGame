using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;

    private static int playerHealth;

    private void Update()
    {
        playerHealth = PlayerHealth.currentHealth;
        healthBar.fillAmount = playerHealth / 100f;
    }
}