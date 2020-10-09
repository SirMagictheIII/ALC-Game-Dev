using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    public float topBounds = 35f;
    public float bottomBounds = -15f;
    ///working on a solution for error 234
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < bottomBounds)
        {
            Destroy(gameObject);
        }
    }
}
