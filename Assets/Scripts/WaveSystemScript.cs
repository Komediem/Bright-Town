using System.Collections;
using UnityEngine;
using TMPro;

public class WaveSystemScript : MonoBehaviour
{
    public ZombieSpawn zombieSpawn;
    public ZombieScript zombieScript;
    public PassiveWave passiveWave;

    public TextMeshProUGUI waveState;

    public int currentZombie;
    public int zombieNumber;

    public TextMeshProUGUI waveText;
    private int waveNumber = 0;

    void Start()
    {
        waveState.enabled = false;
        StartCoroutine(Beginning());
    }

    //ALL WAVES

    IEnumerator Beginning()
    {
        yield return new WaitForSeconds(5f);
        waveNumber = 0;
        waveText.text = waveNumber.ToString();
        waveState.text = "Zombies are coming... Be prepared !";
        waveState.enabled = true;

        yield return new WaitForSeconds(10f);
        waveState.enabled = false;

        StartCoroutine(Wave1());
    }

    IEnumerator Wave1()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();
        zombieNumber = 5;
        zombieScript.scorePoints = 10;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(3f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Next Wave in coming...";
        waveState.enabled = true;

        passiveWave.spawnLightZone();

        yield return new WaitForSeconds(10f);
        waveState.enabled = false;

        StartCoroutine(Wave2());
    }

    IEnumerator Wave2()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();
        zombieNumber = 10;
        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(2f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Next Wave in coming...";
        waveState.enabled = true;

        yield return new WaitForSeconds(5f);
        waveState.enabled = false;

        StartCoroutine(Wave3());
        
    }

    IEnumerator Wave3()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();
        zombieNumber = 20;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(1f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Next Wave in coming...";
        waveState.enabled = true;

        yield return new WaitForSeconds(5f);
        waveState.enabled = false;

        StartCoroutine(Wave4());
    }

    IEnumerator Wave4()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();
        zombieNumber = 40;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(1f);
        }


        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Zombies seems a bit different...";
        waveState.enabled = true;

        yield return new WaitForSeconds(5f);
        waveState.enabled = false;

        StartCoroutine(Wave5());
       
    }

    IEnumerator Wave5()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();

        zombieNumber = 20;
        zombieScript.scorePoints = 25;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRunners();
            yield return new WaitForSeconds(1f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Next Wave in coming...";
        waveState.enabled = true;

        yield return new WaitForSeconds(5f);
        waveState.enabled = false;

        StartCoroutine(Wave3());
    }
}
