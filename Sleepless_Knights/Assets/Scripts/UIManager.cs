using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class for managing the UI.
/// </summary>
public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject deathPanel;
    
    /// <summary>
    /// Toggles the death panel when the player dies.
    /// </summary>
    public void ToggleDeathPanel()
    {
        deathPanel.SetActive(!deathPanel.activeSelf);
    }
}
