using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthRandom : MonoBehaviour
{
    //----------------------Edit below here --------------------
    public Slider slider;
    public int maxHealth = 100; //set default
    public int minHealth = 0; //set default
    //----------------------Edit above here --------------------
    public void Start()
    {
        slider.minValue = minHealth;
        slider.maxValue = maxHealth;
    }

    // On Click function
    public void OnClick()
    {
        RandomHealth();
    }

    //----------------------Edit below here --------------------
    public void RandomHealth()
    {
        int randomHealth = Random.Range(minHealth, maxHealth + 1); //random
        slider.value = randomHealth; //value of slider
    }
}
