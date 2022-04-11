using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class for the health of the player.
/// </summary>
public class PlayerHealth : MonoBehaviour
{
    
    private float health = 0f;
    [SerializeField] private float maxHealth = 100f;
    public HealthBar healthBar;

    /// <summary>
    /// Start is called before the first frame update.
    /// Sets the health of the player.
    /// </summary>
    private void Start()
    {
        health = maxHealth;
        healthBar?.SetMaxHealth(maxHealth);
    }

    /// <summary>
    /// Updates the players health from range 0 - 100.
    /// </summary>
    /// <param name="mod">a float</param>
    public void updateHealth(float mod)
    {
        Debug.Log("update health called: " + health);
        health+= mod;
        healthBar.SetHealth(health);

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health <= 0f)
        {
            health = 0f;
            Debug.Log("player respawn");
   
            PlayerDied();
        }

    }
        
    /// <summary>
    /// Sets the scene to a game over scene.
    /// </summary>
    public void PlayerDied(){
        LevelManager.instance.GameOver();
        gameObject.SetActive(false);
    }
}
