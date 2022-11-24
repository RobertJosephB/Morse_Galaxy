using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void goToLevel1()
    {
        SceneManager.LoadScene("GameStart");
    }
    public void goToLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void goToLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
}
