using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyPrefab : MonoBehaviour
{
    [Range(11, 20)]
    public float BounceForce;


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y < 0)
            {
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = BounceForce;
                rb.velocity = newVelocity;
            }


        }

    }
}