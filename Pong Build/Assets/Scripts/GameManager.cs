using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //public fields that store GameObjects from the Scene
    public Text P1Text;                 //From Text UI
    public Text P2Text;                 
    public Ball ball;             //Generic GameObjects to hold the others
    public GameObject P1Paddle;
    public GameObject P2Paddle;
    public float Speed;                 //control the Speed of the Paddles
    private bool running = false;

    //by default all fields and methods are private
    [SerializeField] int Win = 5;       // This is a field that we want to edit in the Editor but nothing else should have access to change it


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PaddleMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    private void PaddleMovement()
    {
        //Player 2 Movements
        // when I presss a key, I go in that direction
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            P2Paddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, Speed);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            P2Paddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -Speed);
        }

        //When I am no longer pressing a key, I want to stop
        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            P2Paddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }
        //Player 1 Movements
        if (Input.GetKeyDown(KeyCode.W))
        {
            P1Paddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, Speed);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            P1Paddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -Speed);
        }

        //When I am no longer pressing a key, I want to stop
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            P1Paddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }

    }
    private void StartGame()
    {
        //check if the game is already started
        if (running)
        {
            return;
        }
        //trigger the ball to rotate and move
        else
        {
            ball.Launch();
        }
    }
}
