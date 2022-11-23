using System.Collections;
using UnityEngine;
using TMPro;

public class WaveSystemScript : MonoBehaviour
{
    public ZombieSpawn zombieSpawn;
    public ZombieScript zombieScript;

    public GameObject waveState;

    public int currentZombie;
    public int zombieNumber;

    public TextMeshProUGUI waveText;
    private int waveNumber = 0;

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

        waveState.SetActive(true);

        yield return new WaitForSeconds(5f);
        waveState.SetActive(false);

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

        waveState.SetActive(true);

        yield return new WaitForSeconds(5f);
        waveState.SetActive(false);

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

        waveState.SetActive(true);

        yield return new WaitForSeconds(5f);
        waveState.SetActive(false);

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
       
        waveState.SetActive(true);

        yield return new WaitForSeconds(5f);
        waveState.SetActive(false);

        StartCoroutine(Wave5());
       
    }

    IEnumerator Wave5()
    {
        waveNumber++;
        waveText.text = waveNumber.ToString();
        zombieNumber = 20;

        for (int i = 0; i < zombieNumber; i++)
        {
            currentZombie++;
            zombieSpawn.spawnRunners();
            yield return new WaitForSeconds(1f);
        }

        yield return new WaitUntil(() => currentZombie == 0);

        waveState.SetActive(true);

        yield return new WaitForSeconds(5f);
        waveState.SetActive(false);

        StartCoroutine(Wave3());
    }
}
