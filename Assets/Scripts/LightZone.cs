using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightZone : MonoBehaviour
{
    public int gatlingBulletGain = 2;
    public GameObject interactText;

    public void Start()
    {
        interactText = GameObject.Find("InteractionText");
    }

    public void OnTriggerStay2D(Collider2D interactionLightZone)
    {
        interactText.SetActive(true);

        if (Input.GetKey(KeyCode.E) && FindObjectOfType<PlayerFirePower>().currentGatlingBullet < 500)
        {
            FindObjectOfType<PlayerFirePower>().currentGatlingBullet += gatlingBulletGain;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        interactText.SetActive(false);
    }
}
