using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParameters : MonoBehaviour
{

    public string myFirstName = "Noah";
    public string myLastName = "Parsons";


    // Start is called before the first frame update
    void Start()
    {
        PrintMyName(myFirstName,myLastName, 23);
        PrintMyName("Bruce", "Wayne", 40);
        PrintMyName("barry", "Allen");
    }

    // string nameOne = myFirstName
    // string nameTwo = myLastName 
    public void PrintMyName(string nameOne, string nameTwo, int age = 20)
    {
        Debug.Log(nameOne+ " " +nameTwo);
        Debug.Log("Their age is: " + age);
    }
}
