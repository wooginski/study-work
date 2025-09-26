using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseStatements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = Random.Range(0, 10);

        if (randomNumber < 5) 
        {
            Debug.Log("the number is less than 5");

        }
        else
        {
            Debug.Log("The number is greater than 5");  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
