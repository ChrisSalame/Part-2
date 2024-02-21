using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetTwoLERP : MonoBehaviour
{
    //These are the variables that are needed for a lerp, the start position and end position are what they state, the start of the object and the end position.
    //The speed and interpolation are what determine how fast it is and how long it takes to get from point a to point b

    public Transform petTwoStartPosition;
    public Vector3 petTwoNewPosition = new Vector3(8, -3, 0);
    public AnimationCurve petLERPAnimationCurve;
    public float petLERPSpeed = 0;
    public float petLERPinterpolation;


    void Start()
    {

    }


    void Update()
    {
        //This defines the interpolation and has the animation curve define how long it will take to move from the starting point to end point
        petLERPinterpolation = petLERPAnimationCurve.Evaluate(petLERPSpeed);

        //This is what moves the actual object
        transform.position = Vector3.Lerp(petTwoStartPosition.position, petTwoNewPosition, petLERPinterpolation);

        //This the LERP speed by the internal timer
        petLERPSpeed = petLERPSpeed + Time.deltaTime; 

    }
}
