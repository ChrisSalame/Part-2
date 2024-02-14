using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float wSpeed = 5f;
    public float wTimer = 5;
    public Rigidbody2D wrigidBody;

    void Start()
    {
        wrigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.Translate(wSpeed * Time.deltaTime, 0, 0);
        wTimer += Time.deltaTime;
        //Debug.Log(wTimer);
        if (wTimer > 5.0) 
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        Vector2 wMovement = new Vector2(wSpeed * Time.deltaTime, 0);
        wrigidBody.MovePosition(wrigidBody.position + wMovement);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
       collision.gameObject.SendMessage("TakeDamage", 1);
    }
}
