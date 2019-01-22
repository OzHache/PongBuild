using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;          // This is a reference to the rigidbody and will eliminate long code
    private float velX;
    private float velY;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velX = rb.velocity.x;
        velY = rb.velocity.y;
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

        rb.velocity = transform.right * 8f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {


        //if we hit a wall flip the Y 
        if (collision.collider.CompareTag("Wall"))
        {
            rb.velocity = new Vector2(velX, -velY);
        }

        //if we hit a paddle flip the X
        if (collision.collider.CompareTag("Paddle"))
        {
            rb.velocity = new Vector2(-velX, velY);
        }
    }
}
