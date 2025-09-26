    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //input must be done in the update section 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Bar pressed, this runs once until release");
        }

       else if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space Bar has been pressed, then released, this wont run until released");
        }
       else if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("the space bar is still being pressed");
        }




    }
}
