using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FootballPlayer : MonoBehaviour
{
    public Color selectedColor;
    public Color defaultColor;
    public SpriteRenderer spriteRenderer;
    Rigidbody2D rb;
    public float speed = 100;



    void Start()
    {

       spriteRenderer = GetComponent<SpriteRenderer>();
        Selected(false);
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

    }

    void OnMouseDown() 
    {
        Controller.SetSelectedPlayer(this);
    }



    public void Selected(bool isSelected) 
    { 
        if (isSelected)
        {
            spriteRenderer.color = selectedColor;
        }

        else

        {
            spriteRenderer.color = defaultColor;
        }

    }

       public void Move(Vector2 direction)
    {
        rb.AddForce(direction * speed, ForceMode2D.Impulse);
    }

}
