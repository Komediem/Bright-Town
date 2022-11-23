using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class WaveSystemScript : MonoBehaviour
{
    public ZombieSpawn zombieSpawn;
    public ZombieScript zombieScript;

    public GameObject waveState;

    public int currentZombie;
    public int zombieNumber;


    void Start()
    {
        waveState.SetActive(false);
        StartCoroutine(Wave1());
    }

    void Update()
    {

    }

    //ALL WAVES

    IEnumerator Wave1()
    {
        zombieNumber = 5;
        zombieScript.scorePoints = 10;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(3f);
        }

        if(currentZombie == 0)
        {
            waveState.SetActive(true);

            yield return new WaitForSeconds(5f);
            waveState.SetActive(false);

            StartCoroutine(Wave2());
        }
    }

    IEnumerator Wave2()
    {
        zombieNumber = 10;
        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(2f);
        }


        if (currentZombie == 0)
        {
            waveState.SetActive(true);

            yield return new WaitForSeconds(5f);
            waveState.SetActive(false);

            StartCoroutine(Wave3());
        }
    }

    IEnumerator Wave3()
    {
        zombieNumber = 20;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(1f);
        }

        
        if (currentZombie == 0)
        {
            waveState.SetActive(true);

            yield return new WaitForSeconds(5f);
            waveState.SetActive(false);

            StartCoroutine(Wave4());
        }
    }

    IEnumerator Wave4()
    {
        zombieNumber = 40;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(1f);
        }


        if (currentZombie == 0)
        {
            waveState.SetActive(true);

            yield return new WaitForSeconds(5f);
            waveState.SetActive(false);

            StartCoroutine(Wave5());
        }
    }

    IEnumerator Wave5()
    {
        zombieNumber = 20;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRunners();
            yield return new WaitForSeconds(1f);
        }


        if (currentZombie == 0)
        {
            waveState.SetActive(true);

            yield return new WaitForSeconds(5f);
            waveState.SetActive(false);

            StartCoroutine(Wave3());
        }
    }
}
