using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public List<Vector2> points;
    public float newPointThreashold = 0.2f;

    Vector2 lastPosition;

    LineRenderer lineRenderer;

    void OnMouseDown()
    {
        points = new List<Vector2>();
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
    }

    //Comment
    void OnMouseDrag()
    {
        Vector2 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Vector2.Distance(currentPosition, lastPosition) > newPointThreashold)
        {
            points.Add(currentPosition);
            lineRenderer.positionCount++;
            lineRenderer.SetPosition(lineRenderer.positionCount - 1, currentPosition);
            lastPosition = currentPosition;
        }
    }
    void Start()
    { 
            lineRenderer = GetComponent<LineRenderer>();
            lineRenderer.positionCount = 1;
            lineRenderer.SetPosition(0, transform.position);
    }
    
}
