using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float damage;
    public float fireRate;
    public float range;

    public Transform playerHead;

    private float currentFireRate;

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
        }
    }

    public void Attack()
    {
        RaycastHit hit;

        if(Physics.Raycast(playerHead.position, playerHead.forward, out hit, range))
        {
            Debug.Log(hit.transform.name + " with the " + hit.transform.tag + " tag" + " has been hit");

            AttackableGameObject target = hit.transform.GetComponent<AttackableGameObject>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}