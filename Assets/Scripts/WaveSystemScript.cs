using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystemScript : MonoBehaviour
{
    public float spawnRate = 1f;
    private float nextSpawn = 0.0f;

    public ZombieSpawn zombieSpawn;
    public int zombieNumber;

    void Start()
    {
        WaveSystem();
    }

    void WaveSystem()
    {

    }

    void Wave1()
    {
        zombieNumber = 5;

        if (Time.time > nextSpawn && zombieNumber > 0)
        {
            zombieNumber -= 1;
            nextSpawn = Time.time + spawnRate;
            zombieSpawn.spawnZombie();
        }
    }
}
