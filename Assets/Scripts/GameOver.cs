using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenus : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject pauseMenu;
    public GameObject firePowerBar;

    public Animator pauseMenuAnimation;

    public void Start()
    {
        gameOverMenu.SetActive(false);
        firePowerBar.SetActive(false);
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverMenu.SetActive(true);
        firePowerBar.SetActive(false);
    }

    public void Pause()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            firePowerBar.SetActive(false);
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        firePowerBar.SetActive(false);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
