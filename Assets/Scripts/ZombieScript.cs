using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    public GameObject player;
    public float speed;

    public int MaxHealth = 10;
    public int CurrentHealth;

    public FireBallScript FireballDamage;

    
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D hitByFireball)
    {
        CurrentHealth -= FireballDamage.damages;
    }

    public void Death()
    {

    }
}
