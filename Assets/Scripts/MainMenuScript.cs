using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public Animation settingsMenuAnimation;
    public Animation buttonsMenuAnimation;

    // Start is called before the first frame update
    void Start()
    {
        buttonsMenuAnimation.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SettingsMenuAnimation()
    {
        settingsMenuAnimation.Play();
    }
}
