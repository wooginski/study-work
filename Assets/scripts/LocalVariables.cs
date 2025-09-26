using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalVariables : MonoBehaviour
{

    public string myName = "Noah";
    public int myHealth = 100;
    private float myHeight = 195.19f;



    // Start is called before the first frame update
    void Start()
    {
        int temporaryHealth = 0; //local/temp variables only exist between the curly or lowly curly braces
        //maybe i take poison damage
        temporaryHealth = myHealth; // take the current value of my health, at this point it is 100
        //it reduces my health by 20 for a short time
        myHealth = myHealth - 20; // my health is currently 80 however temporary health is 100 still
        Debug.Log("Current health is: " + myHealth + "the temp health is" + temporaryHealth);
        //i want to restore my health to its previous point
        myHealth = temporaryHealth; // effectively my health resets back to 100
        Debug.Log("Current health is: " + myHealth);

        //check to see if my name is noah and print out the current value
        if(myName == "Noah")
        {
            Debug.Log("Michael is : " + myHealth + " the temp health is " + temporaryHealth);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
