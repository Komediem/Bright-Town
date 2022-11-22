using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystemScript : MonoBehaviour
{
    public ZombieSpawn zombieSpawn;
    public ZombieScript zombieScript;

    public GameObject waveState;


    public int zombieNumber;


    void Start()
    {
        StartCoroutine(Wave1());
    }

    //ALL WAVES

    IEnumerator Wave1()
    {
        zombieNumber = 5;

        for (int i = 0; i < zombieNumber; i++)
        {
            zombieSpawn.spawnZombie();
            yield return new WaitForSeconds(3f);
        }

        //When the Wave has ended

        waveState.SetActive(true);

        yield return new WaitForSeconds(5f);
        waveState.SetActive(false);

        StartCoroutine(Wave2());
    }

    IEnumerator Wave2()
    {
        zombieNumber = 10;
        for (int i = 0; i < zombieNumber; i++)
        {
            zombieSpawn.spawnZombie();
            yield return new WaitForSeconds(2f);
        }

        //When the Wave has ended

        waveState.SetActive(true);

        yield return new WaitForSeconds(8f);
        waveState.SetActive(false);

        StartCoroutine(Wave2());
    }

    IEnumerator Wave3()
    {
        zombieNumber = 10;
        zombieScript.speed = 2f;

        for (int i = 0; i < zombieNumber; i++)
        {
            zombieSpawn.spawnZombie();
            yield return new WaitForSeconds(2f);
        }

        //When the Wave has ended

        waveState.SetActive(true);

        yield return new WaitForSeconds(8f);
        waveState.SetActive(false);

        StartCoroutine(Wave2());
    }
}
