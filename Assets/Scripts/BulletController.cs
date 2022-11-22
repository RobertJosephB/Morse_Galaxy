using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    int health = 1;

    public float speed = 5f;
    public float deactivateTimer = 3f;
    public char code;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bullet Code: " + code);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if(health <= 0) {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        health--;
    }

    void Move()
    {
        Vector3 temp = transform.position;
        temp.y += speed * Time.deltaTime;
        transform.position = temp;
    }
}
