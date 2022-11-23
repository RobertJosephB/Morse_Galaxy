using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipSelectionStart : MonoBehaviour
{
    GameObject AceToggle;
    GameObject HammerToggle;
    GameObject MantaToggle;
    GameObject TalonToggle;

    // Start is called before the first frame update
    void Start()
    {
        AceToggle = GameObject.Find("AceToggle");
        HammerToggle = GameObject.Find("HammerToggle");
        MantaToggle = GameObject.Find("MantaToggle");
        TalonToggle = GameObject.Find("TalonToggle");

        switch(PlayerPrefs.GetString("ship", "Ace"))
        {
            case "Ace": 
                        AceToggle.GetComponent<Toggle>().isOn = true; 
                        HammerToggle.GetComponent<Toggle>().isOn = false; 
                        MantaToggle.GetComponent<Toggle>().isOn = false; 
                        TalonToggle.GetComponent<Toggle>().isOn = false;
                        break;
            case "Hammer": 
                        AceToggle.GetComponent<Toggle>().isOn = false; 
                        HammerToggle.GetComponent<Toggle>().isOn = true; 
                        MantaToggle.GetComponent<Toggle>().isOn = false; 
                        TalonToggle.GetComponent<Toggle>().isOn = false;
                        break;
            case "Manta": 
                        AceToggle.GetComponent<Toggle>().isOn = false; 
                        HammerToggle.GetComponent<Toggle>().isOn = false; 
                        MantaToggle.GetComponent<Toggle>().isOn = true; 
                        TalonToggle.GetComponent<Toggle>().isOn = false;
                        break;
            case "Talon": 
                        AceToggle.GetComponent<Toggle>().isOn = false; 
                        HammerToggle.GetComponent<Toggle>().isOn = false; 
                        MantaToggle.GetComponent<Toggle>().isOn = false; 
                        TalonToggle.GetComponent<Toggle>().isOn = true;
                        break;
        }
    }
}
