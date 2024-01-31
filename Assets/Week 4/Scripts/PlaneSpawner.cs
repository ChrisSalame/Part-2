using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;

public class PlaneSpawner : MonoBehaviour
{
    public float timer = 0;
    public GameObject PlanePrefab;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 5.0)
        {
            timer += Time.deltaTime;
            print(timer);
            
            
        }
        Instantiate(PlanePrefab, spawn.position, spawn.rotation);
        if (timer >= 5.0) 
        {
            timer = 0;
            
        }


    }
}
