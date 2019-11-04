using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Float a rigidbody object a set distance above a surface.

   
    Rigidbody2D rb2D;

    public bool PlayerHeard = false;
    public bool PlayerSeen = false;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // Cast a ray straight down.
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);

        // If it hits something...
        if (hit.collider != null)
        {
            //The Player is seen
            PlayerSeen = true;

        }

        // If it doesn't...
        if (hit.collider == null)
        {
            //The Player is unseen
            PlayerSeen = false;

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //If the player is in the collision they are heard
        PlayerHeard = true;
    }

    void OnCollisionExit (Collision collision)
    {
        //If the player leaves the collision, they are no longer heard
        PlayerHeard = false;
    }
}
