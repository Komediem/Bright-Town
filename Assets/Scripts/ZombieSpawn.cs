using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour
{
    public Transform Spawner1, Spawner2, Spawner3, Spawner4;

    public GameObject zombie1;

    public void spawnZombie()
    {
        int randomSpawner = Random.Range(1, 4);

        if(randomSpawner == 1)
        {
            Instantiate(zombie1, Spawner1.position, Quaternion.identity);
        }
        if(randomSpawner == 2)
        {
            Instantiate(zombie1, Spawner2.position, Quaternion.identity);
        }
        if (randomSpawner == 3)
        {
            Instantiate(zombie1, Spawner3.position, Quaternion.identity);
        }
        if (randomSpawner == 4)
        {
            Instantiate(zombie1, Spawner4.position, Quaternion.identity);
        }
    }
}
