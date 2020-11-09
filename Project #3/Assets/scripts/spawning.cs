using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(30, 0 ,-2);
    private float startDelay = 2f;
    private float repeatDelay = 10f;
    
    private PlayCont playContS;
    
    // (x, y, z)
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
        
        playContS = GameObject.Find("Player").GetComponent<PlayCont>();
    }

    // Uses new idea and spawns
    void SpawnObstacle()
    {
    if(playContS.gameOver == false)
        {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
