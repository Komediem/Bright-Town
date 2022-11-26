using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFirePower : MonoBehaviour
{
    public FirePowerBar firePowerBar;

    public int maxFirePower = 200;
    public int currentFirePower;

    public GatlingModeBar gatlingModeBar;

    public int maxGatlingBullet = 300;
    public int currentGatlingBullet;

    void Start()
    {
        currentFirePower = maxFirePower;
        firePowerBar.SetMaxFirePower(maxFirePower);
        currentGatlingBullet = maxGatlingBullet;
        gatlingModeBar.SetMaxGatlingBar(maxGatlingBullet);
    }

    public void LoseEnergy(int damage)
    {
        currentFirePower -= damage;
        firePowerBar.SetFirePower(currentFirePower);
    }

    public void LoseGatlingBullet(int bullets)
    {
        currentGatlingBullet -= bullets;
        gatlingModeBar.SetGatlingBar(currentGatlingBullet);
    }
}
