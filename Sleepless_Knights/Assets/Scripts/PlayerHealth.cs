using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    
    private float health = 0f;
    [SerializeField] private float maxHealth = 100f;
    public HealthBar healthBar;
    

    private void Start(){
      
        health = maxHealth;
        healthBar?.SetMaxHealth(maxHealth);
        
    }

    /// <summary>
    /// updates the players health from range 0 - 100
    /// </summary>
    /// <param name="mod"></param>
    public void updateHealth(float mod){
        Debug.Log("update health called: " + health);

        health+= mod;
        healthBar.SetHealth(health);
        if (health > maxHealth){
            health = maxHealth;
        }else if(health <= 0f)
        {
            health = 0f;
            Debug.Log("player respawn");
   
            PlayerDied();
        }

    }
        
    public void PlayerDied(){
        LevelManager.instance.GameOver();
        gameObject.SetActive(false);
    }
}
