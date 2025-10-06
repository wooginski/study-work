using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndGameScript : MonoBehaviour
{

    public int endTextState = 0;
    public TextMeshProUGUI endScript;
    // Start is called before the first frame update
    void Start()
    {
        endScript.text = "oh? [SPACE]";
        Debug.Log("oh");
        endTextState = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        switch(endTextState)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Debug.Log("boolbasaur is evolving!!!");
                    endTextState = endTextState+1;    
                }
                break;
            case 1:
                endScript.text = "boolbasaur is evolving!!! [SPACE]";
                
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Debug.Log("Congratulations!!! Your Boolbasaur evolved into Struct-asaur");
                    endTextState = endTextState + 1;
                }
                break;
            case 2:
                endScript.text = "Congratulations!!! Your Boolbasaur evolved into Struct-asaur [SPACE]";
               
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    endTextState = endTextState + 1;
                }
                break;
            case 3:
                endScript.text = "Thank you for playing Bugemon [SPACE]";
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    endTextState = endTextState + 1;
                }
                break;
                case 4:
                endScript.text = "THE END!!!";
                break;



        }
    }
}
