using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoController : MonoBehaviour
{

    public char morseLetter;
    public char morseLetter2;

    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public AudioClip[] audioArray;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.volume = 0.5f;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        switch (morseLetter)
        {
            case 'E':
                changeSprite(spriteArray[0]);
                audioSource.PlayOneShot(audioArray[0], 1);
                break;
            case 'N':
                changeSprite(spriteArray[1]);
                audioSource.PlayOneShot(audioArray[1], 1);
                break;
            case 'T':
                changeSprite(spriteArray[2]);
                audioSource.PlayOneShot(audioArray[2], 1);
                break;
            case 'S':
                changeSprite(spriteArray[3]);
                audioSource.PlayOneShot(audioArray[3], 1);
                break;
            case 'M':
                changeSprite(spriteArray[4]);
                audioSource.PlayOneShot(audioArray[4], 1);
                break;
            case 'G':
                changeSprite(spriteArray[5]);
                audioSource.PlayOneShot(audioArray[5], 1);
                break;
            case 'V':
                changeSprite(spriteArray[6]);
                audioSource.PlayOneShot(audioArray[6], 1);
                break;
            case 'Y':
                changeSprite(spriteArray[7]);
                audioSource.PlayOneShot(audioArray[7], 1);
                break;
        }

        switch (morseLetter2)
        {
         
            case 'V':
                changeSprite(spriteArray[8]);
                audioSource.PlayOneShot(audioArray[8], 1);
                break;
            case 'E':
                changeSprite(spriteArray[9]);
                audioSource.PlayOneShot(audioArray[9], 1);
                break;
            case 'S':
                changeSprite(spriteArray[10]);
                audioSource.PlayOneShot(audioArray[10], 1);
                break;
            case 'T':
                changeSprite(spriteArray[11]);
                audioSource.PlayOneShot(audioArray[11], 1);
                break;
        }

    }
    
    void OnCollisionEnter(Collision collision)
    {

    }

    void changeSprite(Sprite newSprite)
    {
        spriteRenderer.sprite = newSprite;
    }
}
