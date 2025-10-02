using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
   public Player playerOne;
   public Player playerTwo;

    // Start is called before the first frame update
    void Start()
    {
        if(playerTwo == null)
        {
            Debug.Log("there is no reference to player two");
        }
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.A))
        {
            playerOne.Attack();
        }
     else if (Input.GetKeyDown(KeyCode.D))
        {
            playerOne.Defend();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            if (playerTwo != null)
                playerTwo.Attack();
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            if (playerTwo != null)
            {
                playerTwo.Defend();

            }
        }
    }

    



}
