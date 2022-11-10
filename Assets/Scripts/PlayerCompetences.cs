using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCompetences : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    
    public GameObject fireball;
    public PlayerFirePower playerFirePower;
    public Transform playerTransform;

    private int firebeamCost = 1;

    public float fireRate = 0.3f;
    private float nextFire = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
       // mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
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

        if(Input.GetMouseButton(1))
        {
            FireBeamAttack();
        }
    }

    public void FireballAttack()
    {
        Instantiate(fireball, playerTransform.position, Quaternion.identity);
    }

    public void FireBeamAttack()
    {
        playerFirePower.LoseEnergy(firebeamCost);
    }
}
