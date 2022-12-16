using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    public GameObject playerStats;
    public Slider hpSlider;

    public void InitBar(float maxValue) {
        hpSlider.maxValue = maxValue;
        hpSlider.value = maxValue;
    }

    public void SetValue(float hpvalue) {
        hpSlider.value = hpvalue;
    }

    void Update()
    {
    if (hpSlider.value <= 0)
    {
    playerStats.GetComponent<PlayerStats>().ReloadGame();
    }
    }
}