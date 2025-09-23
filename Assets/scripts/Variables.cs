using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// this is the summary which holds all the information of my variables activity
/// </summary>

public class Variables : MonoBehaviour
{

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
