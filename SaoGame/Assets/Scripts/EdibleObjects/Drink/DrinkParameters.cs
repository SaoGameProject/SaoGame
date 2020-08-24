using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkParameters : MonoBehaviour
{
    public static int healthToAdd;

    public void GiveHealth(int drinkHealth)
    {
        drinkHealth += PlayerHealth.currentHealth;
    }
}
