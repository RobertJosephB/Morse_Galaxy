using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoController : MonoBehaviour
{

    public char morseLetter;
    public char morseLetter2;

    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        switch (morseLetter)
        {
            case 'E':
                changeSprite(spriteArray[0]);
                break;
            case 'N':
                changeSprite(spriteArray[1]);
                break;
            case 'T':
                changeSprite(spriteArray[2]);
                break;
            case 'S':
                changeSprite(spriteArray[3]);
                break;
            case 'M':
                changeSprite(spriteArray[4]);
                break;
            case 'G':
                changeSprite(spriteArray[5]);
                break;
            case 'V':
                changeSprite(spriteArray[6]);
                break;
            case 'Y':
                changeSprite(spriteArray[7]);
                break;
        }

        switch (morseLetter2)
        {
         
            case 'V':
                changeSprite(spriteArray[8]);
                break;
            case 'E':
                changeSprite(spriteArray[9]);
                break;
            case 'S':
                changeSprite(spriteArray[10]);
                break;
            case 'T':
                changeSprite(spriteArray[11]);
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
