using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndOr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = Random.Range(0, 10);

        if(randomNumber >0 && randomNumber <5)
        {
            Debug.Log("the number is between 0 an 5");
        }

        if(randomNumber <6 || randomNumber <8)
        {
            Debug.Log("the random number was less than 6 or less than 8");
        }

        if(randomNumber < 8 || (randomNumber >0 && randomNumber <5))
        {
            Debug.Log("the random number was less than 8 or was between 0 and 5");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
