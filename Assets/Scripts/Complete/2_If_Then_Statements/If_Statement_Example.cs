using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statement_Example : MonoBehaviour
{

    public bool areYouHappyOnTheInside;
    public bool lookHappyOnOutside;

    public string playerName;
    public string barName;
    public int playerAge;
    public bool hasFakeId;
    private bool enterBar;
    private bool canPlayerDrink;

    public Renderer playerColor;
    
    // Start is called before the first frame update
    void Start()
    {
        playerColor = this.gameObject.GetComponent<Renderer>();
        
        // Solitary If Statement: ONE CONDITION
        if (lookHappyOnOutside) //First Condition
        {
            Debug.Log("You look very happy, " + playerName + ".");
        }

        // If-Then Statement with TWO CONDITIONS
        if (lookHappyOnOutside && areYouHappyOnTheInside) //First Condition
        {
            Debug.Log("You emanate so much happiness down to your core, " + playerName + "!");
        }
        else //Default Condition if First Condition is not met
        {
            Debug.Log("Is everything okay? Doy you want to talk");
        }

        // It-Then Statement with THREE CONDITIONS
        if (playerAge >= 21)
        {
            print(playerName + " can legally drink at " + barName + ".");
        }
        else if (hasFakeId == true)
        {
            print(playerName + " can illegally drink at " + barName + ".");
        }
        else
        {
            print("Give it up and just go home and drink some apple juice.");
        }

    }

    // Update is called once per frame
    void Update()
    {
       

        // It-Then Statement with THREE CONDITIONS with LOGICAL OPERATORS
        if (areYouHappyOnTheInside == true && lookHappyOnOutside)
        {
            playerColor.material.color = Color.magenta;
        }
        
        else
        {
            playerColor.material.color = Color.blue;
        }
    }
}
