using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casting : MonoBehaviour
{
    public int myCurrentHealth = 100;
    public int myMaxHealth = 100; 


    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log((3f/4f) * 100 + "%"); //should give 75%
        myCurrentHealth -= 20; //take 20 of my hp
        float displayHealthAmount = ((( (float) myCurrentHealth/ (float) myMaxHealth)*100) -0.56f); 
        Debug.Log(Mathf.CeilToInt(displayHealthAmount) + "%");  // Always rounds up
        Debug.Log(Mathf.FloorToInt(displayHealthAmount) + "%"); // Always rounds down 
        Debug.Log(Mathf.Round(displayHealthAmount) + "%"); // Follows normal rounding rules

        string numberFive = "5";

        float x = float.Parse(numberFive);
        
        Debug.Log(float.IsNaN(x) +  " " + x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
