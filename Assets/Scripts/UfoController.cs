using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoController : MonoBehaviour
{

    public char morseLetter;

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
