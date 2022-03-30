using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float health = 0f;
    [SerializeField] private float maxHealth = 100f;

    private void Start(){
        health = maxHealth;
    }

    /// <summary>
    /// updates the players health from range 0 - 100
    /// </summary>
    /// <param name="mod"></param>
    public void updateHealth(float mod){
        health+= mod;
        if(health > maxHealth){
            health = maxHealth;
        }else if(health <= 0f)
        {
            health = 0f;
            Debug.Log("player respawn");
        }
    }
}
