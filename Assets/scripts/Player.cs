using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 0;
    public string myName;
    // Start is called before the first frame update
    void Start()
    {
        health = Random.Range(0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Attack()
    {
        Debug.Log(myName + " Attacked!");
    }


    public void Defend()
    {
        Debug.Log(myName + " Defended");
    }
}
