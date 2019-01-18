using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch()
    {
        //return it to the center
        transform.position = Vector3.zero;
        //transform.position = new Vector3(0f, 0f, 0f);


        //remove the rotation
        transform.Rotate(Vector3.zero);

        //choose a random direction
        transform.Rotate(Vector3.forward * UnityEngine.Random.Range(0f, 360f));
        //set velocity

        gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * 8f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Capture the Velocity of the Ball
        float velX = gameObject.GetComponent<Rigidbody2D>().velocity.x;
        float velY = gameObject.GetComponent<Rigidbody2D>().velocity.y;

        //if we hit a wall flip the Y 
        /*
         * Before we add this collision we need to add tags to the Walls 
         */ 
       
        //if we hit a paddle flip the X
        /*
         *Before we add this collision we need to add tags to the Paddles 
         */
    }

    //Method to check to see if the Ball has triggered the goal. 

    /*
     * Get the Goal object from the collision
     * Get the ID from the Goal object (we need to make an enum)
     * Send it to the Game Manager to update scores
     * 
     */
}
