using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRangeX = 9f;
    public float spawnRangeZ = 9f;
    public float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, spawnInterval);
    }

    void SpawnEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 33, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
