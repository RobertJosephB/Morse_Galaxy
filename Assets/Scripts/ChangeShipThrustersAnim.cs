using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShipThrustersAnim : MonoBehaviour
{

    public Animator thrusters;
    public SpriteRenderer spriteRendered;
    public Sprite ShipSpriteAce;
    public Sprite ShipSpriteHammer;
    public Sprite ShipSpriteManta;
    public Sprite ShipSpriteTalon;

    // Start is called before the first frame update
    void Start()
    {
        spriteRendered = gameObject.GetComponent<SpriteRenderer>();
        thrusters = GetComponent<Animator>();
                

        if(PlayerPrefs.GetString("ship")== "Ace")
        {
            spriteRendered.sprite = ShipSpriteAce;
            thrusters.Play("SThrusters");
        }
            
        else if(PlayerPrefs.GetString("ship") == "Hammer")
        {
            spriteRendered.sprite = ShipSpriteHammer;
            thrusters.Play("HThrusters");
        }
            
        else if (PlayerPrefs.GetString("ship") == "Manta")
        {
            spriteRendered.sprite = ShipSpriteManta;
            thrusters.Play("MThrusters");
        }
            
        else if (PlayerPrefs.GetString("ship") == "Talon")
        {
            spriteRendered.sprite = ShipSpriteTalon;
            thrusters.Play("SThrusters");
        }
            
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
