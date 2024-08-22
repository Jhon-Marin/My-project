using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject objectToShoot; // El objeto que quieres spawnear
    public GameObject objectToShoot2;
    public float initialSpawnTime = 2f; // Tiempo inicial de spawneo
    private float timeSinceLastSpawn = 0;
    private float NumberofBC = 0;
   

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (NumberofBC <= 4)
        {
            if (timeSinceLastSpawn >= initialSpawnTime)
            {
                Instantiate(objectToShoot, transform.position, transform.rotation);
                NumberofBC++;

                timeSinceLastSpawn = 0;

            }
        }
        else {
            Instantiate(objectToShoot2, transform.position, transform.rotation);
            NumberofBC = 0;
        }
    }

}