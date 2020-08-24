﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth;

    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetHealth(currentHealth);
    }

    public void TakeDamage(int DamageAmount)
    {
        currentHealth -= DamageAmount;

        if (currentHealth <= 0)
        {
            Die();

        }

        healthBar.SetHealth(currentHealth);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
