using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    //the Gameover script variable
    public GameOverScript gameOverScript;

    //jump force variable
    [SerializeField] int jumpForce;
    [SerializeField] int walkForce =1;
    [SerializeField] float horizontalMove;
    [SerializeField] Vector2 gravityPlayer;
    public Animator animator;

    //a true or false variable that checks if it's grounded
    private bool isGrounded = false;


    //This is where variables should be
    //us camelcasing for variables
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("The rb is " + rb);
        //creating a debuglog helps programmer

    }

    // Update is called once per frame
    void Update()
    {
        //ADDED CODE HERE
  

        if (gameOverScript.isAlive == true)
        {
            if (Physics2D.gravity == new Vector2(0,-5f))
            {
                //this will make my player move right
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.right);
                Debug.Log("Key D has been pressed");
            }
            //this will make my player move left
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.left);
                Debug.Log("Key A has been pressed");
            }
            //this doesnt jump but it does do the debug
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded != false)
                {
                    rb.AddForce(Vector3.up * jumpForce);
                    Debug.Log("you jumped");
                    isGrounded = false;
                }
            }
            }
    if (Physics2D.gravity == new Vector2(0,5f))
            {
                //this will make my player move right
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.left);
                Debug.Log("Key D has been pressed");
            }
            //this will make my player move left
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.right);
                Debug.Log("Key A has been pressed");
            }
            //this doesnt jump but it does do the debug
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded != false)
                {
                    rb.AddForce(Vector3.down * jumpForce);
                    Debug.Log("you jumped");
                    isGrounded = false;
                }
            }
            }
            if (Physics2D.gravity == new Vector2(-5f,0))
            {
                //this will make my player move right
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.down);
                Debug.Log("Key D has been pressed");
            }
            //this will make my player move left
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.up);
                Debug.Log("Key A has been pressed");
            }
            //this doesnt jump but it does do the debug
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded != false)
                {
                    rb.AddForce(Vector3.right * jumpForce);
                    Debug.Log("you jumped");
                    isGrounded = false;
                }
            }
            }
    if (Physics2D.gravity == new Vector2(5f,0f))
            {
                //this will make my player move right
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.up);
                Debug.Log("Key D has been pressed");
            }
            //this will make my player move left
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.down);
                Debug.Log("Key A has been pressed");
            }
            //this doesnt jump but it does do the debug
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded != false)
                {
                    rb.AddForce(Vector3.left * jumpForce);
                    Debug.Log("you jumped");
                    isGrounded = false;
                }
            }
            }
        }
    }
    //This will check to see if player collides with ground
    private void OnCollisionEnter2D(Collision2D collider)
    {
        //checks for the player if its on the ground
        if (isGrounded != true)
        {
            if (collider.gameObject.CompareTag ("Ground"))
            {
                isGrounded = true;
                Debug.Log("ground is detected");
            } 
        }
        //This would kill the player when on death
        if (collider.gameObject.CompareTag ("DeathLine"))
            {
                Debug.Log("The fog is coming");
                Destroy(gameObject);
                gameOverScript.isAlive = false;
            }
             
    }  
}