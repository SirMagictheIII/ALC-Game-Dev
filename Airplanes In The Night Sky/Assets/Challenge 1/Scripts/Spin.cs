using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationSpeed = 500;
    public float turnSpeed = 2;
    
    void start()
    {
    
    }
    void Update()
    {
    transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}