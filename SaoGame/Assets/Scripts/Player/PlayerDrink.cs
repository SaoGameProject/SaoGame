using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDrink : MonoBehaviour
{
    public float range;
    public int healthFromDrink;

    public Transform playerHead;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Drink()
    {
        //finding an drinkable GO
        RaycastHit hit;

        if (Physics.Raycast(playerHead.position, playerHead.forward, out hit, range))
        {
            Debug.Log(hit.transform.name + " with the " + hit.transform.tag + " tag" + " will be drunk");

            //the target of the Raycast gives health
            DrinkParameters target = hit.transform.GetComponent<DrinkParameters>();
            if (target != null)
            {
                target.GiveHealth(healthFromDrink);
            }
        }
    }
}
