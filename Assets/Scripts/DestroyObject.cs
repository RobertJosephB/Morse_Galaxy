using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public GameObject TutorialPanel;

    public void start()
    {  
    }

    public void update()
    {
       
    }


    public void resumeOnClose()
    {


        if (TutorialPanel.activeInHierarchy == true)
        {
            TutorialPanel.SetActive(false);
            Time.timeScale = 1;
        }

    
    }
}
