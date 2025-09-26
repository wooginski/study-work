using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public string myFirstName = "Noah";
    public string myLastName = "Parsons";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Print my name creates a string that is the first Name and my last name joined 
    /// </summary>
    public void PrintMyName()
    {
        string fullName = myFirstName + myLastName;
        Debug.Log("My name is: " + fullName);
        PrintMyName(); //you can put a function in a function however it will crash unity by creating an infinite loop via recursion unless you have conditions to make it not call itself

    }

}
