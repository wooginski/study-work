using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operands : MonoBehaviour
{
    public int numberOne = 3; // my first number to use
    public int numberTwo = 4; // my second number to use
    public int result = 0; // the result of my operations to the next set of numbers.

    // Start is called before the first frame update
    void Start()
    {
        /* - is our subtraction
         * + is our addition
         * * is our multiplication
         *  / is our division
         *  % is our modular
         *  () is our operation 
         *  = is assigning values
         */

        // () = parenthesis determine order of excecution
        // {} = curley braces define scope of function or class
        // [] = square brackets allow to access elements of a collection



       // result = numberOne + numberTwo; // the result variable is set to the value of 3 plus 4
       // result = numberOne - numberTwo; // the result variable is set to the value of 3 minus 4
       // result = numberOne * numberTwo; // the result variable is set to the value of 3 multiplied by 4
       // result = numberOne / numberTwo; // the result variable is set to the value of 4 divided by 4 
       // result = ((numberOne + numberTwo) * numberOne); // our parenthesis determine our order of operation 
       // result = numberOne % numberTwo; // this will result in the remainder of the division of this calculation 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
