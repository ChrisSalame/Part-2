using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetMovement : MonoBehaviour
{
    Rigidbody2D petRB;
    Animator petAnimator;
    Vector2 newPetPosition;
    Vector2 petMovement;
    public float petSpeed = 3;
    bool clickingOnSelf = false;


    void Start()
    {
        petRB = GetComponent<Rigidbody2D>();
        petAnimator = GetComponent<Animator>();

    }

    //This code sets and resets the press button so that pet doesn't walk and overlap the button on the screen
    private void OnMouseDown()
    {
        clickingOnSelf = true;
    }
    private void OnMouseUp()
    {
        clickingOnSelf = false;
    }

    private void FixedUpdate()
    {

        petMovement = newPetPosition - (Vector2)transform.position;
        if (petMovement.magnitude < 0.1)
        {
            petMovement = Vector2.zero;
        }
        petRB.MovePosition(petRB.position + petMovement.normalized * petSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        petAnimator.SetFloat("Pet Movement",petMovement.magnitude);
        //This makes it so that the crab can move from clicking the map but prevents the crab from moving somewhere
        //the UI elements are such as under the button when the button is pressed
        if (Input.GetMouseButtonDown(0) && !clickingOnSelf && !EventSystem.current.IsPointerOverGameObject())
        {
            newPetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButtonDown(1))
        {
            //This makes it so that when the player right clicks the crab turns around
            petAnimator.SetTrigger("Shell");
        }


    }
}
