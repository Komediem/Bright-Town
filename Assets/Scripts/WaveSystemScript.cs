using System.Collections;
using UnityEngine;
using TMPro;

public class WaveSystemScript : MonoBehaviour
{
    public ZombieSpawn zombieSpawn;
    public ZombieScript zombieScript;
    public PassiveWave passiveWave;
    public LightZone lightZone;

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
        zombieScript.scorePoints = 15;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(2f);
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
            yield return new WaitForSeconds(1.5f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Next Wave in coming...";
        waveState.enabled = true;

        yield return new WaitForSeconds(10f);
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

        yield return new WaitForSeconds(10f);
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

        yield return new WaitForSeconds(10f);
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

        yield return new WaitForSeconds(10f);
        waveState.enabled = false;

        StartCoroutine(Wave6());
    }

    IEnumerator Wave6()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();

        zombieNumber = 30;
        zombieScript.scorePoints = 20;
        zombieScript.MaxHealth = 15;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(2f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Next Wave in coming...";
        waveState.enabled = true;

        yield return new WaitForSeconds(10f);
        waveState.enabled = false;

        StartCoroutine(Wave7());
    }

    IEnumerator Wave7()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();

        zombieNumber = 50;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(1.5f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Next Wave in coming...";
        waveState.enabled = true;

        yield return new WaitForSeconds(10f);
        waveState.enabled = false;

        StartCoroutine(Wave8());
    }

    IEnumerator Wave8()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();

        zombieScript.scorePoints = 30;
        zombieNumber = 35;
        zombieScript.MaxHealth = 10;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRunners();
            yield return new WaitForSeconds(1f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Next Wave in coming...";
        waveState.enabled = true;

        yield return new WaitForSeconds(10f);
        waveState.enabled = false;

        StartCoroutine(Wave9());
    }

    IEnumerator Wave9()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();

        zombieScript.scorePoints = 20;
        zombieNumber = 70;
        zombieScript.MaxHealth = 15;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(1f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "What is this... An Invasion !";
        waveState.enabled = true;

        yield return new WaitForSeconds(10f);
        waveState.enabled = false;

        StartCoroutine(Wave10());
    }

    IEnumerator Wave10()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();

        zombieNumber = 150;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(0.5f);
        }

        zombieScript.scorePoints = 25;
        zombieNumber = 50;
        zombieScript.MaxHealth = 10;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRunners();
            yield return new WaitForSeconds(0.5f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Next Wave in coming...";
        waveState.enabled = true;

        yield return new WaitForSeconds(10f);
        waveState.enabled = false;

        StartCoroutine(Wave11());
    }

    IEnumerator Wave11()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();

        zombieScript.scorePoints = 20;
        zombieNumber = 90;
        zombieScript.MaxHealth = 20;
        zombieScript.speed = 2.25f;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(1f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Next Wave in coming...";
        waveState.enabled = true;

        yield return new WaitForSeconds(10f);
        waveState.enabled = false;

        StartCoroutine(Wave12());
    }

    IEnumerator Wave12()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();

        zombieNumber = 100;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(0.75f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Next Wave in coming...";
        waveState.enabled = true;

        yield return new WaitForSeconds(10f);
        waveState.enabled = false;

        StartCoroutine(Wave13());
    }

    IEnumerator Wave13()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();

        zombieNumber = 120;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRegularZombie();
            yield return new WaitForSeconds(0.75f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.text = "Next Wave in coming...";
        waveState.enabled = true;

        yield return new WaitForSeconds(10f);
        waveState.enabled = false;

        StartCoroutine(Wave10());
    }
}
