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

        //if we hit a paddle flip the X
    }
}
