using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void Start()
    {
        slider.value = PlayerPrefs.GetFloat("HealthBarNumber", slider.value);
        SendMessage("healthBar", slider.value, SendMessageOptions.DontRequireReceiver);
    }


    public void TakeDamage(float damage) 
    {
        slider.value -= damage;

        healthValueSceneSwapSave();
    }

    public void healthValueSceneSwapSave()
    {
        PlayerPrefs.SetFloat("HealthBarNumber", slider.value);
    }

}
