using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    public float topBounds = 35f;
    public float LowBounds = -20;
    //floats item
    
    void Start()
       { 
       Time.timeScale = 1;
       }
       
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        
        else if(transform.position.z < LowBounds)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
    }
}
