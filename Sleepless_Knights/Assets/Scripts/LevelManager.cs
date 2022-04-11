using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that manages the Level UI. 
/// </summary>
public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    /// <summary>
    /// Starts the level manager, else destroy it.
    /// </summary>
    private void Awake()
    {
        if (LevelManager.instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    /// <summary>
    /// Toggles the game over screen.
    /// </summary>
    public void GameOver()
    {
        UIManager _ui = GetComponent<UIManager>();
        if(_ui != null)
        {
            _ui.ToggleDeathPanel();
        }
    }
}

