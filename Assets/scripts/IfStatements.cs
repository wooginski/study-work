using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

    public string myName = "Noah";
    public int coolNumber = 5;
    public bool amITall = true;

    // Start is called before the first frame update
    void Start()
    {
        if (coolNumber > 3);
        {
            Debug.Log("5 is greater than 3");
        }
        if (3 < coolNumber);
        {
            Debug.Log("3 is less than 5");
        }
        if (3 <= 3) ;
        {
            Debug.Log("3 is less than or equal to 3");
        }
        if (5 >= 3) ;
        {
            Debug.Log("5 is greater than or equal to 3");
        }
        if (5 == 5) ;
        {
            Debug.Log("5 is equal to 5");
        }
        if (myName == "Noah") ;
        {
            Debug.Log("Noah");

        }
        if (myName != "noah") ;
        {
            Debug.Log("this is not true due to case sensitivity");
        }

        if (amITall == true) ;
        {
            Debug.Log("Yes this is true");
        }
        if (amITall == false) ;
        {
            Debug.Log("this is false");
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
