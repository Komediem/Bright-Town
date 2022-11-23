using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour
{
    public Transform Spawner1, Spawner2, Spawner3, Spawner4;

    public GameObject regularZombie;
    public GameObject runners;

    public void spawnRegularZombie()
    {
        int randomSpawner = Random.Range(1, 5);

        if(randomSpawner == 1)
        {
            Instantiate(regularZombie, Spawner1.position, Quaternion.identity);
        }
        if(randomSpawner == 2)
        {
            Instantiate(regularZombie, Spawner2.position, Quaternion.identity);
        }
        if (randomSpawner == 3)
        {
            Instantiate(regularZombie, Spawner3.position, Quaternion.identity);
        }
        if (randomSpawner == 4)
        {
            Instantiate(regularZombie, Spawner4.position, Quaternion.identity);
        }
    }

    public void spawnRunners()
    {
        int randomSpawner = Random.Range(1, 5);

        if (randomSpawner == 1)
        {
            Instantiate(runners, Spawner1.position, Quaternion.identity);
        }
        if (randomSpawner == 2)
        {
            Instantiate(runners, Spawner2.position, Quaternion.identity);
        }
        if (randomSpawner == 3)
        {
            Instantiate(runners, Spawner3.position, Quaternion.identity);
        }
        if (randomSpawner == 4)
        {
            Instantiate(runners, Spawner4.position, Quaternion.identity);
        }
    }
}
