using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightZone : MonoBehaviour
{
    public int gatlingBulletGain = 2;
    private GameObject interactText;

    public void Start()
    {
        interactText = GameObject.Find("InteractionText");
    }

    public void OnTriggerEnter2D(Collider2D interactionLightZone)
    {
        if (Input.GetKey(KeyCode.E) && FindObjectOfType<PlayerFirePower>().currentGatlingBullet < 500)
        {
            interactText.SetActive(true);
            FindObjectOfType<PlayerFirePower>().currentGatlingBullet += gatlingBulletGain;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        interactText.SetActive(false);
    }
}
