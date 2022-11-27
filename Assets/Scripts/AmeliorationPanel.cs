using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmeliorationPanel : MonoBehaviour
{
    public GameObject ameliorationPanel;

    public GameObject interactionText;

    public void OnTriggerStay2D(Collider2D interactionPanel)
    {
        if (interactionPanel.gameObject.CompareTag("Player") == true)
        {
            interactionText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                ameliorationPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public void OnTriggerExit2D(Collider2D interactionPanel)
    {
        interactionText.SetActive(false);
    }
}
