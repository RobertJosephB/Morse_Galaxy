using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefChanges : MonoBehaviour
{
    public void toggleAce(bool tog)
    {
        if(tog)
        {
            PlayerPrefs.SetString("ship", "Ace");
        }
    }

    public void toggleHammer(bool tog)
    {
        if(tog)
        {
            PlayerPrefs.SetString("ship", "Hammer");
        }
    }

    public void toggleManta(bool tog)
    {
        if(tog)
        {
            PlayerPrefs.SetString("ship", "Manta");
        }
    }

    public void toggleTalon(bool tog)
    {
        if(tog)
        {
            PlayerPrefs.SetString("ship", "Talon");
        }
    }
}
