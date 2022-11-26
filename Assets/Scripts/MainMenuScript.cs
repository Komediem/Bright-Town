using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public Toggle fullscreen;
    public GameObject introBlackScreen;

    // Start is called before the first frame update
    void Start()
    {
        fullscreen.isOn = Screen.fullScreen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void Intro()
    {
        introBlackScreen.SetActive(true);
    }

    public void ApplyGraphics()
    {
        Screen.fullScreen = fullscreen.isOn;
    }
}
