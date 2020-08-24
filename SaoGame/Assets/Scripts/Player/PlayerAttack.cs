﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int damage;                //damage made by the attack
    public float fireRate;              //time between each shot
    public float range;                 //range of the attack

    public Transform playerHead;

    private float currentFireRate;      //current time between each shots

    public Animator playerAnimator;

    private void Awake()
    {
        currentFireRate = fireRate;
    }

    private void Update()
    {
        currentFireRate += Time.deltaTime;

        if(Input.GetMouseButtonDown(0) && currentFireRate >= fireRate)
        {
            currentFireRate = 0f;
            Attack();
            Debug.Log("An attack has been done");
        }
    }

    public void Attack()
    {
        //start attack animation
        playerAnimator.SetTrigger("isAttacking");

        //finding an attackable GO
        RaycastHit hit;

        if(Physics.Raycast(playerHead.position, playerHead.forward, out hit, range))
        {
            Debug.Log(hit.transform.name + " with the " + hit.transform.tag + " tag" + " has been hit");

            //the target of the Raycast takes damage
            NotPlayerHealth target = hit.transform.GetComponent<NotPlayerHealth>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}