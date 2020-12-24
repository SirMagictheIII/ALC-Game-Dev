using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public float sideBounds = 8f;
    public float TopBounds = 9f;
    //creates boundaries so the player cannot escape the map


    void Update()
    {
        if(transform.position.x < -sideBounds)
           transform.position = new Vector3(-sideBounds, transform.position.y, transform.position.z);

        if(transform.position.x > sideBounds)
            transform.position = new Vector3(sideBounds, transform.position.y, transform.position.z);

        if (transform.position.z > TopBounds)
            transform.position = new Vector3(transform.position.x, transform.position.y, TopBounds);

        if (transform.position.z < -TopBounds)
            transform.position = new Vector3(transform.position.x, transform.position.y, -TopBounds);
    }
}
