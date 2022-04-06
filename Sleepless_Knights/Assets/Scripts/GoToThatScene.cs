using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToThatScene : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void ReloadTheGame(){
         SceneManager.LoadScene("MainScene 1");
    }
    public void ReturnToMainMenu(){
    
        SceneManager.LoadScene("StartMenus");
    
    }
}
