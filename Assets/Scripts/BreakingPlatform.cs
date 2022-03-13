using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingPlatform : MonoBehaviour
{
    [Range(5, 10)]
    public float jumpForce;
   
   
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
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = jumpForce;
                rb.velocity = newVelocity;
                Destroy(gameObject);
            }


        }

    }

  
}
