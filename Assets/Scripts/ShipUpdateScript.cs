using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipUpdateScript : MonoBehaviour
{
    public SpriteRenderer spriteRendered;
    public Sprite ShipSpriteAce;
    public Sprite ShipSpriteHammer;
    public Sprite ShipSpriteManta;
    public Sprite ShipSpriteTalon;

    // Start is called before the first frame update
    void Start()
    {
        spriteRendered = gameObject.GetComponent<SpriteRenderer>();
        

        if(PlayerPrefs.GetString("ship")== "Ace")
            spriteRendered.sprite = ShipSpriteAce;
        else if(PlayerPrefs.GetString("ship") == "Hammer")
            spriteRendered.sprite = ShipSpriteHammer;
        else if (PlayerPrefs.GetString("ship") == "Manta")
            spriteRendered.sprite = ShipSpriteManta;
        else if (PlayerPrefs.GetString("ship") == "Talon")
            spriteRendered.sprite = ShipSpriteTalon;
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }
}
