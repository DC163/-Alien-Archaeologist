using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMoveent : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;

    [SerializeField]
    private float speed = 4.0f;
    [SerializeField]
    private float JumpSpeed = 10.0f;
    [SerializeField]
    public Collider2D groundSensor = null;
    [SerializeField]
    public LayerMask groundLayer = 0;
    [SerializeField]
    public int jumpcount = 0;
    [SerializeField]
    public Joystick myJoystick = null;

    //Awake

    private void Awake()
    { //Getting the Rigidbody2D component attached o the same object as this script
        physicsBody = GetComponent<Rigidbody2D>();
    }

    //functions are pascal case
    public void MoveLeft()
    { 
        //make a variable to hold our velocity
        //get the current velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;

        //set our velocity to movfe in the negative X direction (left)
        newVelocity.x = -speed;

        //update our physics component to be our newly changed value
        physicsBody.velocity = newVelocity; 
    }

    public void MoveRight()
    {
        //make a variable to hold our velocity
        //get the current velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;

        //set our velocity to movfe in the positive X direction (right)
        newVelocity.x = speed;

        //update our physics component to be our newly changed value
        physicsBody.velocity = newVelocity;
    }

    public void Jump()
    {
        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            // Make a variable to hold our velocity
            // gather current velocity from physics component
            Vector2 newVelocity = physicsBody.velocity;

            newVelocity.y = JumpSpeed;

            physicsBody.velocity = newVelocity;
            jumpcount = 1;
            Debug.Log(jumpcount);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = speed * myJoystick.Horizontal;
        physicsBody.velocity = newVelocity;
    }
}
