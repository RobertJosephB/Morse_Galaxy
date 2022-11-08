using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoCollision : MonoBehaviour
{
    // Start is called before the first frame update

    

    void start()
    {
        // Morse Code Dictionary
        // Random Generator (A, B, C)


    }

    void update()
    {


    }

    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger");

        // Write Code to Destroy Ship and Reduce Health of Player
        // Write Animation for Destroying Ship 
        Destroy(gameObject);
    }
}
