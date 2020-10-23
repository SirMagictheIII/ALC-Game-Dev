using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
    //destroy this object
    Destroy(gameObject);
    //destroy other objects when it collides with it.
    Destroy(other.gameObject);
        
    }
}
