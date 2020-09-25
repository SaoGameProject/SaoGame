using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodParameters : MonoBehaviour
{
    private int playerHealth;

    private void Update()
    {
        playerHealth = PlayerHealth.currentHealth;
    }

    public void GiveFoodHealth(int foodHealth)
    {
        foodHealth += playerHealth;
        Destroy(gameObject);
    }
}
