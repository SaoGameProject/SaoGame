using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotPlayerHealth : MonoBehaviour
{
    public int health;

    public void TakeDamage(int DamageAmount)
    {
        health -= DamageAmount;

        if (health <= 0)
        {
            Die();

        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
