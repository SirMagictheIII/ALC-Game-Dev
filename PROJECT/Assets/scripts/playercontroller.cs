using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    //access modifier type name operator value
    private int speed = 20;
    private float turnSpeed = 25;
    
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
    horizontalInput = Input.GetAxis("Horizontal");
    forwardInput = Input.GetAxis("Vertical");
    //moves teh vehicle forwards based on forwardInput
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    //Rotates the vehicle left and right based on horizontal input
    transform.Rotate(Vector3.up, turnSpeed * horitzontalInput * Time.deltaTime);
        
    }
}
