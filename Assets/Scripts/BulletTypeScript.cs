using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTypeScript : MonoBehaviour
{
    public SpriteRenderer spriteRendered;
    public Sprite bulletAce;
    public Sprite bulletHammer;
    public Sprite bulletManta;
    public Sprite bulletTalon;

    // Start is called before the first frame update
    void Start()
    {
        spriteRendered = gameObject.GetComponent<SpriteRenderer>();
        

        if(PlayerPrefs.GetString("ship")== "Ace")
            spriteRendered.sprite = bulletAce;
        else if(PlayerPrefs.GetString("ship") == "Hammer")
            spriteRendered.sprite = bulletHammer;
        else if (PlayerPrefs.GetString("ship") == "Manta")
            spriteRendered.sprite = bulletManta;
        else if (PlayerPrefs.GetString("ship") == "Talon")
            spriteRendered.sprite = bulletTalon;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
