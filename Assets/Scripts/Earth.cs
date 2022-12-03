using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Earth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public HealthBar healthBar;

    public GameObject DefeatPanel;
    public GameObject SettingsPanel;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.SetHealth(currentHealth);
        
        if(currentHealth <= 0) {
            whenHealthDepleted();
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        currentHealth--; 
    }     

    public void whenHealthDepleted()
    {
        if (DefeatPanel.activeInHierarchy == false)
        {
            DefeatPanel.SetActive(true);
            SettingsPanel.SetActive(false);
            Time.timeScale = 0;
        }

    }




}
