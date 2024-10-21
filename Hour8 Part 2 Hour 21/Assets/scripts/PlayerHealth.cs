using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // initial health points
    int healthpoints = 3992;

    // Start is called before the first frame update
    void Start()
    {
        // health potions
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);

        // Log the value of healthpoints
        Debug.Log(healthpoints);
    }

    // Update is called once per frame
    void Update()
   {
    
   }
    // returning health
    public int UsePotion(int health)
    {
        health += 400;  // Add 400 to health
        return health;  // Return the updated health
    }
}
