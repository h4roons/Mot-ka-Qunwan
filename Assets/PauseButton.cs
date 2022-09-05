using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public GameObject PauseMenu;
    public void GamePause()
    {
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
    }
    public void GameContinue()
    {
        
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LevelSelector()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
