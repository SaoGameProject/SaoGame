using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDrinkOrEat : MonoBehaviour
{
    public float range;
    public int healthFromDrink;

    public Transform playerHead;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Drink();
            Debug.Log("A search for drink has been done");
            Eat();
            Debug.Log("A search for food has been done");
        }
    }

    public void Drink()
    {
        //finding an drinkable GO
        RaycastHit drinkHit;

        if (Physics.Raycast(playerHead.position, playerHead.forward, out drinkHit, range))
        {
            Debug.Log(drinkHit.transform.name + " with the " + drinkHit.transform.tag + " tag" + " got hit by the drink raycast");

            //the target of the Raycast gives health
            DrinkParameters target = drinkHit.transform.GetComponent<DrinkParameters>();
            if (target != null)
            {
                target.GiveHealth(healthFromDrink);
                Debug.Log("A drink gave " + healthFromDrink + " health");
            }
        }
    }

    public void Eat()
    {
        RaycastHit eatHit;

        if(Physics.Raycast(playerHead.position, playerHead.forward, out eatHit, range))
        {
            Debug.Log(eatHit.transform.name + " with the " + eatHit.transform.tag + " tag" + " got hit by the eat raycast");

            //the target of the Raycast gives health
            DrinkParameters target = eatHit.transform.GetComponent<DrinkParameters>();
            if (target != null)
            {
                target.GiveHealth(healthFromDrink);
                Debug.Log("A food gave " + healthFromDrink + " health");
            }
        }
    }
}
