using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class that handles going from different Scenes.
/// </summary>
public class GoToThatScene : MonoBehaviour
{

    /// <summary>
    /// Plays the game.
    /// </summary>
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /// <summary>
    /// Quits the game.
    /// </summary>
    public void quitGame()
    {
        Application.Quit();
    }

    /// <summary>
    /// Reloads the game.
    /// </summary>
    public void ReloadTheGame()
    {
         SceneManager.LoadScene("MainScene 1");
    }

    /// <summary>
    /// Returns to the main menu.
    /// </summary>
    public void ReturnToMainMenu(){
    
        SceneManager.LoadScene("StartMenus");
    
    }
}
