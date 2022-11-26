using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmeliorationPanel : MonoBehaviour
{
    public GameObject ameliorationPanel;

    public PassiveWave passiveWave;

    public void OnTriggerStay2D(Collider2D interactionPanel)
    {
        if (interactionPanel.gameObject.CompareTag("Player") == true)
        {
            passiveWave.InteractionTextEnter();

            if (Input.GetKey(KeyCode.E))
            {
                
            }
        }
    }
}
