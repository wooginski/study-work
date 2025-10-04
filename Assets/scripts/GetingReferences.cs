using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetingReferences : MonoBehaviour
{
    public Player playerReference;
    public Transform playerObject;

    // Start is called before the first frame update
    void Start()
    {
        playerReference = playerObject.GetComponent<Player>(); 


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
