using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkParameters : MonoBehaviour
{
    private int playerHealth;

    private void Update()
    {
        playerHealth = PlayerHealth.currentHealth;
    }

    public void GiveHealth(int drinkHealth)
    {
        drinkHealth += playerHealth;
        Destroy(gameObject);
    }
}
