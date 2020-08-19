using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public LayerMask playerLayerMask;
    public float maxDistance;

    void Start()
    {

    }

    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward) * maxDistance, playerLayerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * maxDistance, Color.blue);
            Debug.Log("Raycast touched a player");
        }
    }
}