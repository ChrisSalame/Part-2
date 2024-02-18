using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public Slider hungerBar;
    //public float hungerDecline = 0.00001f;


    private void Update()
    {
        //hungerBar.value -= hungerDecline;
    }


    public void feedFood(float feed)
    {
        hungerBar.value += feed;
    }
    public void increaseHunger(float starve)
    {
        hungerBar.value += starve;
    }
}