using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 20f;
    //allows for the change of range
    public GameObject foodMissile;
    //allows for thorwing food
    
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        
        //if -xRange with xRange are on this line, it loops like Pacman
        if(transform.position.x < -xRange)
        { //constrains leftward movement x @ -10
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        
        }
        if(transform.position.x > xRange)
        { //constrains leftward movement x @ -10
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        
        }
       //spawns food 
       if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodMissile, transform.position, foodMissile.transform.rotation);
        }
    }
}
