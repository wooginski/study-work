using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugging : MonoBehaviour
{

    public string myName = "Noah";
    public int myAge = 23;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log("My current age is "+myAge);
        myAge = myAge + 10;
        Debug.Log("My new age is " + myAge + "how did I age so fast");

        Debug.LogWarning("This is bad");
        Debug.LogError("this will break things");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
