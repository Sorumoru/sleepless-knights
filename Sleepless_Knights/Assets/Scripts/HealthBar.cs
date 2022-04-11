using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class that represents the health bar of an object.
/// </summary>
public class HealthBar : MonoBehaviour
{
    public Slider slider;

    /// <summary>
    /// Sets the max health of the health bar taken from the player.
    /// </summary>
    /// <param name="health">a float</param>
    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    /// <summary>
    /// Sets the current health of the health bar taken from the player.
    /// </summary>
    /// <param name="health"> a float</param>
    public void SetHealth(float health)
    {
        slider.value = health; 
    }


}
