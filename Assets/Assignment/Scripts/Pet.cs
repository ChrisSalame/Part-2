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
        //This manages the hunger bar which the player can interact with. The lower the bar is, the hungier the pet is. 
        hunger = MinHunger;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        //By pressing this is increases the hunger bar and feeds the pet. This code checks if mouse is pressed on the feed button and uses send message to 
        //change the hunger bar on the next scene
        mousePress = true;
        gameObject.SendMessage("feedFood", 1);

    }
    private void OnMouseUp()
    {
        mousePress = false;

    }

    //This is the code that manages the variable that is represented by the bar
    public void feedFood(float feed)
    {
        hunger += feed;
    }

}
