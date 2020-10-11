using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodParameters : MonoBehaviour
{
    private int playerCurrentHealth;
    public PlayerHealth playerHealth;

    private void Update()
    {
        playerCurrentHealth = playerHealth.currentHealth;
    }

    public void GiveFoodHealth(int foodHealth)
    {
        foodHealth += playerCurrentHealth;
        Destroy(gameObject);
    }
}
