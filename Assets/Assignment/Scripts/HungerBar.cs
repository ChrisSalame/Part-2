using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public Slider hungerBar;

    public void Start()
    {
        //This is part of what helps set the PlayerPref that manages the hunger bar which is saved over each scene
        hungerBar.value = PlayerPrefs.GetFloat("hungerBar", hungerBar.value);
    }


    public void feedFood(float feed)
    {

    //this is the same as the last feeFood void, it manages the food bars
    //The line below called the void which saves the variable and has it saved in between each scene starting and closing
        hungerBar.value += feed;
        saveHungerValue();
    }

    public void saveHungerValue()
    {
        PlayerPrefs.SetFloat("hungerBar",hungerBar.value);

    }
}