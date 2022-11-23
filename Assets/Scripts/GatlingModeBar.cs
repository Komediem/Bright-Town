using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatlingModeBar: MonoBehaviour
{
    public Slider slider;

    public void SetMaxGatlingBar(int GatlingBullet)
    {
        slider.maxValue = GatlingBullet;
        slider.value = GatlingBullet;
    }

    public void SetGatlingBar(int GatlingBullet)
    {
        slider.value = GatlingBullet;
    }
}
