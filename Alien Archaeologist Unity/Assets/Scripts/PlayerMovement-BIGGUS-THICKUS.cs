using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;

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
        newVelocity.x = -1;

        //update our physics component to be our newly changed value
        physicsBody.velocity = newVelocity; 
    }

    public void MoveRight()
    {
        //make a variable to hold our velocity
        //get the current velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;

        //set our velocity to movfe in the negative X direction (left)
        newVelocity.x = 1;

        //update our physics component to be our newly changed value
        physicsBody.velocity = newVelocity;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
