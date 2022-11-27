using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSettings : MonoBehaviour
{

    public GameObject SettingsPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenSettingsClicked()
    {
        if (SettingsPanel.activeInHierarchy == false)
        {
            SettingsPanel.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void whenResumeClicked()
    {
        if (SettingsPanel.activeInHierarchy == true)
        {
            SettingsPanel.SetActive(false);
            Time.timeScale = 1;
        }

    }
}
