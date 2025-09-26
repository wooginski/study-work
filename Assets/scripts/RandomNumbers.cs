using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumbers : MonoBehaviour
{
    public int randomNumber = 0;
    public float randomFloatNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, 10); //gives random number between 0-9
        randomFloatNumber = Random.Range(0f, 10f); // gives random number between 0.0f and 10.0f
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
