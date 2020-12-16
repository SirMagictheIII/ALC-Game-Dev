using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private PlayCont playContScript;
    private float leftBound = -12f;
    
    // Start is called before the first frame update
    void Start()
    {
        playContScript = GameObject.Find("Player").GetComponent<PlayCont>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(playContScrip.gameOver == false)
        {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
