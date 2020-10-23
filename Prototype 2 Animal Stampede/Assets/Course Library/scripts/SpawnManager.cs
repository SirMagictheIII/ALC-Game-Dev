using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
//[] is an array

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 19f;
    private float spawnPosZ = 29f;
    
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    // public animal index
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, (spawnPosZ));
    
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
       
    }
}