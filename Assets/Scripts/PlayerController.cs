using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 3f;     //speed of movement
    float shipBoundaries = 0.6f;    //precaution for when the ship touches the edge of the screen

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
        audioSource.volume = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Horizontal Movement
        Vector3 pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;  

        //Set Boundaries of the Player
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrthographic = Camera.main.orthographicSize * screenRatio;

        if(pos.x + shipBoundaries > widthOrthographic) {
            pos.x = widthOrthographic - shipBoundaries;
        }

        if(pos.x - shipBoundaries < -widthOrthographic) {
            pos.x = -widthOrthographic + shipBoundaries;
        }

        //Audio
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) {
             StartCoroutine(AudioFadeScript.FadeIn(audioSource, 0.5f));
        }

        //Audio
        else if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) {
            StartCoroutine(AudioFadeScript.FadeOut(audioSource, 0.5f));
        }

        //Update the ship position
        transform.position = pos;
    }
}
