using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySwitch : MonoBehaviour
{
    public int currentDisplay;
    public GameObject canvas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentDisplay)
        {
            case 0:
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.SetActive(false);
            currentDisplay  = currentDisplay + 1;
        }
        break;
            case 1:
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    canvas.SetActive(true);
                    currentDisplay = currentDisplay - 1;
                }
                break;
        }
    }
}
