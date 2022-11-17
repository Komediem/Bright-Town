using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieScript : MonoBehaviour
{
    public Transform target;
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
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
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
