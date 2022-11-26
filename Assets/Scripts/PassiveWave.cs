using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveWave : MonoBehaviour
{
    public GameObject lightZone;

    public Transform LightSpawn1, LightSpawn2, LightSpawn3, LightSpawn4;
    public GameObject interactionText;

    public void spawnLightZone()
    {
        int randomLightSpawn = Random.Range(1, 5);

        if (randomLightSpawn == 1)
        {
            Instantiate(lightZone, LightSpawn1.position, Quaternion.identity);
        }
        if (randomLightSpawn == 2)
        {
            Instantiate(lightZone, LightSpawn2.position, Quaternion.identity);
        }
        if (randomLightSpawn == 3)
        {
            Instantiate(lightZone, LightSpawn3.position, Quaternion.identity);
        }
        if (randomLightSpawn == 4)
        {
            Instantiate(lightZone, LightSpawn4.position, Quaternion.identity);
        }
    }

    public void InteractionTextEnter()
    {
        interactionText.SetActive(true);
    }

    public void InteractionTextExit()
    {
        interactionText.SetActive(false);
    }
}
