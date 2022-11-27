using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public void start()
    {  
        Debug.Log("Test");
    }

    public void update()
    {
        Debug.Log("Test");
        if(Input.GetKey(KeyCode.Space))
            {
                Debug.Log("Escape pressed");
                Destroy(gameObject);
            }

    }
}
