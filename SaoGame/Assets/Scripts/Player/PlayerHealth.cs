﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    [HideInInspector]
    public int currentHealth;

    public GameObject playerDeathVisual;

    private void Start()
    {
        currentHealth = maxHealth;

        playerDeathVisual.SetActive(false);
    }

    public void TakeDamage(int DamageAmount)
    {
        currentHealth -= DamageAmount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player died");
        playerDeathVisual.SetActive(true);
    }
}
