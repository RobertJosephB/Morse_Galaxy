using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void goToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
        Time.timeScale = 0;
    }
    public void goToLevel1()
    {
        SceneManager.LoadScene("GameStart");
        Time.timeScale = 1;
    }
    public void goToLevel2()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }
    public void goToLevel3()
    {
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1;
    }
}
