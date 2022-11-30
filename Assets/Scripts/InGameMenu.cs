using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class InGameMenu : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject Pause;
    public GameObject ValidQuit;
    public GameObject ameliorationPannel;
    public GameObject fireballMenu;
    public GameObject gatlingMenu;

    public TextMeshProUGUI maxScoreText;
    public TextMeshProUGUI finalScore;
    public TextMeshProUGUI zombieKilled;

    public ScoreScript scoreScript;
    public WaveSystemScript waveSystemScript;
    public PlayerFirePower playerFirePower;
    public ZombieScript zombieScript;

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

            maxScoreText.text = scoreScript.maxScore.ToString();
            finalScore.text = scoreScript.score.ToString();
            zombieKilled.text = zombieScript.zombieKilledNumber.ToString();
        }
    }

    public void PauseMenu()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Pause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ExitPauseMenu()
    {
        Pause.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        ValidQuit.SetActive(true);
        Pause.SetActive(false);
    }

    public void ValidQuitGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void ExitValidQuitGame()
    {
        Pause.SetActive(true);
        ValidQuit.SetActive(false);
    }

    public void AmeliorationPannelDesactivation()
    {
        ameliorationPannel.SetActive(false);
        Time.timeScale = 1;
    }

    public void FireballAmeliorationMenuDesactivation()
    {
        fireballMenu.SetActive(false);
        ameliorationPannel.SetActive(true);
    }
    public void GatlingAmeliorationMenuDesactivation()
    {
        gatlingMenu.SetActive(false);
        ameliorationPannel.SetActive(true);
    }

    public void FireballAmeliorationMenu()
    {
        fireballMenu.SetActive(true);
        ameliorationPannel.SetActive(false);
    }

    public void GatlingAmeliorationMenu()
    {
        gatlingMenu.SetActive(true);
        ameliorationPannel.SetActive(false);
    }
}
