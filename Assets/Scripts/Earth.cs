using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Earth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public HealthBar healthBar;

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
            Destroy(gameObject);
            SceneManager.LoadScene("MainMenu");
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        currentHealth--; 
    }     
}
