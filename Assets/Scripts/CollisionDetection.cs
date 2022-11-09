using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public int health = 1;          //Health in Changeable through Unity
    public float invulPeriod = 0;   //Default at 0 for all, player ship protect on 2nd instant damage
    float invulTimer = 0;
    int correctLayer;


    // Start is called before the first frame update
    void Start()
    {
        correctLayer = gameObject.layer;
    }


    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Hit! " + gameObject.name);

        health--;
        invulTimer = invulPeriod;
        gameObject.layer = 8;
    }

    // Update is called once per frame
    void Update()
    {
        invulTimer -= Time.deltaTime;
        if(invulTimer <= 0) {
            gameObject.layer = correctLayer;
        }

        if(health <= 0) {
            Destroyed();
        }
    }

    void Destroyed() {
        Destroy(gameObject);
    }
}
