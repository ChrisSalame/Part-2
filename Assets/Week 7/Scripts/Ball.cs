using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static float ball;
    Rigidbody2D rbBall;
    public int Score = 0;
    public float resetV = 0;
    Controller controller;



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
        rbBall.transform.position = new Vector2(0,-1);
        rbBall.velocity = new Vector2(0f, 0f);

        Controller.totalScored = Score;

    }

}
