using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

 [Range(5, 10)]
    public float jumpForce;
    bool movingright=true;
    Rigidbody platformrb;
    Vector3 platformvelo = new Vector3();
    Vector3 startpos = new Vector3();
    

     void Start()
    {
        platformrb = gameObject.GetComponent<Rigidbody>();
        startpos = gameObject.transform.position;
    }

     void Update()
    {
        if(movingright)
        {
            platformvelo = platformrb.velocity;
            platformvelo.x += 3 * Time.deltaTime;
            platformrb.velocity = platformvelo;
        }
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
            }


        }

    }
}
