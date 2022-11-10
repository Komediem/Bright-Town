using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirePowerBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxFirePower(int firePower)
    {
        slider.maxValue = firePower;
        slider.value = firePower;
    }

    public void SetFirePower(int firePower)
    {
        slider.value = firePower;
    }
}
