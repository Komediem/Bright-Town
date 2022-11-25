using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject Pause;
    public WaveSystemScript waveSystemScript;
    public PlayerFirePower playerFirePower;

    public bool verif = false;

    private void FixedUpdate()
    {
        PauseMenu();
        GameOverMenu();
    }
    public void GameOverMenu()
    {
        if (playerFirePower.currentFirePower <= 0)
        {
            Time.timeScale = 0;
            GameOver.SetActive(true);
        }
    }

    public void PauseMenu()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Pause.SetActive(true);
            waveSystemScript.waveState.enabled = false;
            Time.timeScale = 0;
        }
    }

    public void ExitPauseMenu()
    {
        Pause.SetActive(false);
        Time.timeScale = 1;
    }
}
