using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenus : MonoBehaviour
{
    public GameObject GameOverMenu;
    public GameObject PauseMenu;

    public Animation pauseMenuEnter;

    private void Update()
    {
        PauseMenu();
    }
    public void GameOverMenu()
    {
        Time.timeScale = 0;
    }
    public void PauseMenu()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pauseMenuEnter.Play();
        }
    }
    public void Resume()
    {
        Time.timeScale = 1;
    }
}
