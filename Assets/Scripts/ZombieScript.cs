using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieScript : MonoBehaviour
{
    private Transform target;
    private Vector2 player;
    public float speed;

    public int MaxHealth = 10;
    public int CurrentHealth;

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

    public void OnCollisionEnter2D(Collision2D hitByAttack)
    {
        if (hitByAttack.gameObject.CompareTag("Fireball") == true)
        {
            CurrentHealth -= FireballDamage.damages;
        }

        if (hitByAttack.gameObject.CompareTag("GatlingBullet") == true)
        {
            CurrentHealth -= GatlingDamage.damages;
        }
    }

    public void Death()
    {
        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
