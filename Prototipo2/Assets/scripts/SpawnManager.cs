using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 1.5f;
    private float spawnInterval = 1;

    public GameObject[] animalPrefabs; 
    private float spawnRangeX = 10f;
    private float spawnPosZ = 20f;

    void Start()
    {
        
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        
        int animalIndex = Random.Range(0, animalPrefabs.Length);

  
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);


       
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

