using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject Pause;

    public Animator PauseAnim;

    private void Update()
    {
        PauseMenu();
    }
    public void GameOverMenu()
    {
        
    }

    public void PauseMenu()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            PauseAnim.SetBool("PauseMenuActivation", true);
        }
    }
}
