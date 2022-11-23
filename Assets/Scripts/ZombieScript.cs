using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieScript : MonoBehaviour
{
    private Transform target;
    private Vector2 player;
    public float speed = 1f;

    public int MaxHealth = 10;
    public int CurrentHealth;

    public int zombieDamages = 10;
    public int scorePoints;

    public FireBallScript FireballDamage;
    public GatlingModeScript GatlingDamage;

    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    
    void Update()
    {
        Movement();
        Death();
    }
    
    public void Movement()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        player = new Vector2(target.position.x, target.position.y);
        transform.position = Vector2.MoveTowards(transform.position, player, speed * Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D hits)
    {
        if (hits.gameObject.CompareTag("Fireball") == true)
        {
            CurrentHealth -= FindObjectOfType<FireBallScript>().damages;
        }

        if (hits.gameObject.CompareTag("GatlingBullet") == true)
        {
            CurrentHealth -= FindObjectOfType<GatlingModeScript>().damages;
        }

        if (hits.gameObject.CompareTag("Player") == true)
        {
            FindObjectOfType<PlayerFirePower>().currentFirePower -= zombieDamages;
            FindObjectOfType<PlayerFirePower>().LoseEnergy(zombieDamages);
        }
    }

    public void Death()
    {
        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
            FindObjectOfType<ScoreScript>().score += FindObjectOfType<WaveSystemScript>().zombieScript.scorePoints;
            FindObjectOfType<WaveSystemScript>().currentZombie -= 1;
        }
    }
}
