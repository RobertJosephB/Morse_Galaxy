using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public int health = 1;          //Health in Changeable through Unity
    public float invulPeriod = 0;   //Default at 0 for all, player ship protect on 2nd instant damage
    float invulTimer = 0;
    int correctLayer;

    public Sprite[] destroySequence;
    public float framesPerSecond = 20;

    // Start is called before the first frame update
    void Start()
    {
        correctLayer = gameObject.layer;
    }

    void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Hit! " + gameObject.name);

        char bulletLetter = collision.gameObject.GetComponent<BulletController>().code;
        char ufoLetter = gameObject.GetComponent<UfoController>().morseLetter;
        char ufoLetter2 = gameObject.GetComponent<UfoController>().morseLetter2;

        if (bulletLetter == ufoLetter) {
            health--;
            invulTimer = invulPeriod;
            gameObject.layer = 8;
        }

        if (bulletLetter == ufoLetter2)
        {
            health--;
            invulTimer = invulPeriod;
            gameObject.layer = 8;
        }
    }

    // Update is called once per frame
    void Update()
    {
        invulTimer -= Time.deltaTime;
        if(invulTimer <= 0) {
            gameObject.layer = correctLayer;
        }

        if(health <= 0) {

            this.PlayDestroyAnimation();

            Destroy(gameObject, 0.5f);
        }
    }

    void PlayDestroyAnimation() {
        int frame = (int)(Time.time * framesPerSecond);

        //loop
        frame = frame % destroySequence.Length;

        //set sprite
        var renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = destroySequence[frame];
    }

}
