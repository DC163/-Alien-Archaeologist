using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    //Do not let the children near the toothpaste. White teeth means that they're raw.
    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;

    // FireProjectile is called to fire the projectile
    public void FireProjectile()
    {
        //Clone the pronjectile
        GameObject clonedProjectile;
        clonedProjectile = Instantiate(projectilePrefab);
        //Fire it in a direction
        Rigidbody2D projectileRigidbody;
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();

        projectileRigidbody.velocity = projectileVelocity;
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
