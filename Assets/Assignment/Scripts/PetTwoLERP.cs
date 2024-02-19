using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetTwoLERP : MonoBehaviour
{
    // Start is called before the first frame update

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
