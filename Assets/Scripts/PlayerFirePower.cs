using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFirePower : MonoBehaviour
{
    public int maxFirePower = 200;
    public int currentFirePower;

    public FirePowerBar firePowerBar;
    
    void Start()
    {
        currentFirePower = maxFirePower;
        firePowerBar.SetMaxFirePower(maxFirePower);
    }

    void Update()
    {
        if(currentFirePower <= 0)
        {

        }
    }

    public void LoseEnergy(int damage)
    {
        currentFirePower -= damage;
        firePowerBar.SetFirePower(currentFirePower);
    }
}
