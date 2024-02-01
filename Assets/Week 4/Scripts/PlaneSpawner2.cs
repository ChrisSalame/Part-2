using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpawner2 : MonoBehaviour
{
    public float timer = 0;
    public GameObject PlaneSpawn;

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
            //print(timer);

        }
        if (timer >= 5.0)
        {
            Vector3 randomPlaneSpawn = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);

            Instantiate(PlaneSpawn, randomPlaneSpawn, transform.rotation = Quaternion.Euler(0,0, Random.Range(-180,180)));

            timer = 0;
        }

    }
}
