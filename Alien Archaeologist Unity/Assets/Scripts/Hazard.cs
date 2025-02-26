using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    public int hazardDamage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //code to handle collision
        Collider2D collider = collision.collider;
        PlayerHealth player = collider.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.ChangingHealth(-hazardDamage);
        }
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
