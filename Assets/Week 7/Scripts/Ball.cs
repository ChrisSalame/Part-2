using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static float ball;
    Rigidbody2D rbBall;
    public float Score = 0;


    void Start()
    {
        rbBall = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score += 1;
        Debug.Log(Score);
        rbBall.transform.position = new Vector2(-12f,-3.5f);

    }

}
