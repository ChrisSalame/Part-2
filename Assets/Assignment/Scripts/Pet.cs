using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public float hunger;
    public float MinHunger = 10;
    bool mousePress = false;

    void Start()
    {
        hunger = MinHunger;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {

        mousePress = true;
        gameObject.SendMessage("feedFood", 1);

    }
    private void OnMouseUp()
    {
        mousePress = false;

    }

    public void feedFood(float feed)
    {
        hunger += feed;
    }

}
