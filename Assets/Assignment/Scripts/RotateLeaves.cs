using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLeaves : MonoBehaviour
{

    void Update()
    {
        //This rotates the leaves inthe first scene. The leaves just stiffen up and spread out as if they where normally rectangular over the way I bent them.
        transform.localEulerAngles = new Vector2(0, transform.localPosition.x);
    }
}
