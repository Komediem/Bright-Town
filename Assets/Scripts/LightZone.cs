using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightZone : MonoBehaviour
{
    public int gatlingBulletGain = 1;
    public PassiveWave passiveWave;
    public PlayerCompetences playerCompetences;
    public PlayerFirePower playerFirePower;
    public GatlingModeBar gatlingModeBar;

    private void Start()
    {
        passiveWave = FindObjectOfType<PassiveWave>();
        playerCompetences = FindObjectOfType<PlayerCompetences>();
        playerFirePower = FindObjectOfType<PlayerFirePower>();
        gatlingModeBar = FindObjectOfType<GatlingModeBar>();
    }

    public void OnTriggerStay2D(Collider2D interactionLightZone)
    {
        if (interactionLightZone.gameObject.CompareTag("Player") == true)
        {
            playerCompetences.canFire = false;
            passiveWave.InteractionTextEnter();

            if (Input.GetKey(KeyCode.E) && playerFirePower.currentGatlingBullet <= 500)
            {
                playerFirePower.currentGatlingBullet += gatlingBulletGain;
                gatlingModeBar.SetGatlingBar(playerFirePower.currentGatlingBullet);
                Debug.Log("gain d'énergie");
            }
        }
    }

    public void OnTriggerExit2D(Collider2D interactionLightZone)
    {
        if (interactionLightZone.gameObject.CompareTag("Player") == true)
        {
            playerCompetences.canFire = true;
            passiveWave.InteractionTextExit();
        }
    }
}
