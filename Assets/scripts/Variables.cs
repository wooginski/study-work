using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// this is the summary which holds all the information of my variables activity
/// </summary>

public class Variables : MonoBehaviour
{
    #region code neatness tutorial
    //anything after the slash is ignored by unity

    /*this is a multi line comment 
     * i can keep writing
     * until i put in the
     */

    [Tooltip("this bool holds true or false")] // a tooltip provides a message when we hover over a variable in our inspector
    public bool myFirstBool = true;
    [header("Movement related Variables")] // a header creates a heading in our inspector for our variables
    public bool mySecondBool =false
    [Space(20)] // a space creates a space in the inspector based on the number put in
    public bool myThirdBool = false;
    #endregion

    public int myFirstInt = 1 // an int can only hold whole numbers
    private float myHeight = 180.67f; // a float holds decimal numbers
    public double myFavNumber = 187.45; // a double holds double a float and requires double memory
    public string myName = "Noah" // a string can only hold words 
    public char myInitial = 'S' // a char can only hold a single character
    public bool isWearingAWatch = false; // a bool can only hold true or false

    #region all of my unity functions
    /// <summary>
    /// the start is called on the first frame
    /// </summary>
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion
}
