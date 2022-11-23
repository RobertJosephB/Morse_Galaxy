using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanges : MonoBehaviour
{
    public void goToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void goToShipSelection()
    {
        SceneManager.LoadScene("ShipSelection");
    }
    public void goToMapMenu()
    {
        SceneManager.LoadScene("MapMenu");
    }
}
