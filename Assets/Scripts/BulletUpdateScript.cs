using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletUpdateScript : MonoBehaviour
{

    public SpriteRenderer spriteRendered;
    public Sprite BulletAce;
    public Sprite BulletHammer;
    public Sprite BulletManta;
    public Sprite BulletTalon;

    // Start is called before the first frame update
    void Start()
    {
        spriteRendered = gameObject.GetComponent<SpriteRenderer>();
        

        if(PlayerPrefs.GetString("ship")== "Ace")
            spriteRendered.sprite = BulletAce;
        else if(PlayerPrefs.GetString("ship") == "Hammer")
            spriteRendered.sprite = BulletHammer;
        else if (PlayerPrefs.GetString("ship") == "Manta")
            spriteRendered.sprite = BulletManta;
        else if (PlayerPrefs.GetString("ship") == "Talon")
            spriteRendered.sprite = BulletTalon;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
