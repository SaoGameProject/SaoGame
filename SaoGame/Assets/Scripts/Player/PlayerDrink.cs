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
        if (Input.GetKeyDown(KeyCode.E))
        {
            Drink();
            Debug.Log("A search for drink has been done");
        }
    }

    public void Drink()
    {
        //finding an drinkable GO
        RaycastHit hit;

        if (Physics.Raycast(playerHead.position, playerHead.forward, out hit, range))
        {
            Debug.Log(hit.transform.name + " with the " + hit.transform.tag + " tag" + " got hit by the drink raycast");

            //the target of the Raycast gives health
            DrinkParameters target = hit.transform.GetComponent<DrinkParameters>();
            if (target != null)
            {
                target.GiveHealth(healthFromDrink);
                Debug.Log("A drink gave " + healthFromDrink + " health");
            }
        }
    }
}
