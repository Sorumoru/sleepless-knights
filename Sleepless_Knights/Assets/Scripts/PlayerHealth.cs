using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    
    private float health = 0f;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private Slider slider;
    // public Gradient gradient;
    // public Image fill;

    // public void setMaxHealth(int health){
    //     slider.maxValue = health;
    //     slider.value = health;
    //     fill.color = gradient.Evaluate(1f);
    // }

    private void Start(){
      
        health = maxHealth;
        // slider.maxValue = maxHealth;
    }

    /// <summary>
    /// updates the players health from range 0 - 100
    /// </summary>
    /// <param name="mod"></param>
    public void updateHealth(float mod){
        Debug.Log("update health called: " + health);

        health+= mod;
        if(health > maxHealth){
            // health = maxHealth;
        }else if(health <= 0f)
        {
            health = 0f;
            // slider.value = health;
            Debug.Log("player respawn");
            PlayerDied();
        }

    }
        public void setHealth(){
        float t = Time.deltaTime /1f;
        // slider.value = Mathf.Lerp(slider.value,health,t);

        // fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    public void PlayerDied(){
        LevelManager.instance.GameOver();
        gameObject.SetActive(false);
    }
}
