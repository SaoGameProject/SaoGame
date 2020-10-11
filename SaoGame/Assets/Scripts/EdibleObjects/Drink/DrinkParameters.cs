using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkParameters : MonoBehaviour
{
    private int playerCurrentHealth;
    public PlayerHealth playerHealth;

    private void Update()
    {
        playerCurrentHealth = playerHealth.currentHealth;
    }

    public void GiveDrinkHealth(int drinkHealth)
    {
        drinkHealth += playerCurrentHealth;
        Destroy(gameObject);
    }
}
