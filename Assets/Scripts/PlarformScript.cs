using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlarformScript : MonoBehaviour
{
    [Range(5, 10)]
    public float jumpForce;
    public AudioClip platformSound;


    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerMovement>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if(rb.velocity.y<0)
            {
                AudioSource.PlayClipAtPoint(platformSound, transform.position, 0.7f);
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = jumpForce;
                rb.velocity = newVelocity;
                if(gameObject.GetComponent<BreakingPlatformScript>())
                {
                    GetComponent<BreakingPlatformScript>().BreakPlatform();
                }
               
            }
            

        }
        
    }
}
