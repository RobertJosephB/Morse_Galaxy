using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefChanges : MonoBehaviour
{

    public string selectedShip;
    

    public void toggleAce(bool tog)
    {
        if(tog)
        {
            PlayerPrefs.SetString("ship", "Ace");
            selectedShip = "Ace";
            Debug.Log("Selected " + selectedShip);
            PlayerPrefs.Save();
        }
    }

    public void toggleHammer(bool tog)
    {
        if(tog)
        {
            PlayerPrefs.SetString("ship", "Hammer");
            selectedShip = "Hammer";
            Debug.Log("Selected " + selectedShip);
            PlayerPrefs.Save();
        }
    }

    public void toggleManta(bool tog)
    {
        if(tog)
        {
            PlayerPrefs.SetString("ship", "Manta");
            selectedShip = "Manta";
            Debug.Log("Selected " + selectedShip);
            PlayerPrefs.Save();
        }
    }

    public void toggleTalon(bool tog)
    {
        if(tog)
        {
            PlayerPrefs.SetString("ship", "Talon");
            selectedShip = "Talon";
            Debug.Log("Selected " + selectedShip);
            PlayerPrefs.Save();
        }
    }
}
