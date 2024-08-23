using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn; // El objeto que quieres spawnear
    public GameObject objectToSpawn2;
    public GameObject objectToSpawn3;
    public float initialSpawnTime = 5f; // Tiempo inicial de spawneo
    public float minSpawnTime = 1f; // Tiempo mínimo de spawneo

    private float timeSinceLastSpawn;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= initialSpawnTime)
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            Instantiate(objectToSpawn2, transform.position, transform.rotation);
            Instantiate(objectToSpawn3, transform.position, transform.rotation);
            timeSinceLastSpawn = 0;

            initialSpawnTime -= 1f;
            if (initialSpawnTime < minSpawnTime)
            {
                initialSpawnTime = minSpawnTime;
            }
        }
    }
}