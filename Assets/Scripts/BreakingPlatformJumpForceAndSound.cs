using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingPlatformJumpForceAndSound : MonoBehaviour
{
    [Range(5, 10)]
    public float jumpForce;
    public AudioClip platformSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y < 0)
            {
                AudioSource.PlayClipAtPoint(platformSound, transform.position, 1.2f);
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = jumpForce;
                rb.velocity = newVelocity;
                if (gameObject.GetComponent<BreakingPlatformScript>())
                {
                    GetComponent<BreakingPlatformScript>().BreakPlatform();
                }

            }


        }

    }
}
