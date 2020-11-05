using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(30, 0 ,-2);
    private float startDelay = 2.0f;
    private float repeatDelay = 10.0f;
    
    // (x, y, z)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
    }
    void SpawnObstacle()
    {
    Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
