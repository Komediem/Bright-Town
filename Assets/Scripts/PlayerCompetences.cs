using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCompetences : MonoBehaviour
{
    public GameObject fireball;
    public GameObject GatlingModeBullet;
    public PlayerFirePower playerFirePower;
    public Transform playerTransform;

    private int GatlingModeCost = 1;

    public float fireRate = 0.3f;
    private float nextFire = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Fireball
        if(Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            FireballAttack();
        }

        //GatlingMode
        if(Input.GetMouseButton(1))
        {
            GatlingMode();
        }
    }

    public void FireballAttack()
    {
        Instantiate(fireball, playerTransform.position, Quaternion.identity);
    }

    public void GatlingMode()
    {
        playerFirePower.LoseEnergy(GatlingModeCost);
        Instantiate(GatlingModeBullet, playerTransform.position, Quaternion.identity);
    }
}
