using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public Slider hungerBar;
    //public float hungerDecline = 0.00001f;

    public void Start()
    {
        hungerBar.value = PlayerPrefs.GetFloat("hungerBar", hungerBar.value);
    }


    private void Update()
    {
        //hungerBar.value -= hungerDecline;
    }


    public void feedFood(float feed)
    {
        hungerBar.value += feed;
        saveHungerValue();
    }

    public void saveHungerValue()
    {
        PlayerPrefs.SetFloat("hungerBar",hungerBar.value);

    }

    public void increaseHunger(float starve)
    {
        hungerBar.value += starve;
    }
}