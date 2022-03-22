using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftingPlatform : MonoBehaviour
{
    [Range(5, 10)]
    public float jumpForce;
    bool movingright ;
    Rigidbody platformrb;
    Vector3 platformvelo = new Vector3();
    Vector3 startpos = new Vector3();
    public AudioClip platformSound;
    // Start is called before the first frame update
    void Start()
    {
        platformrb = gameObject.GetComponent<Rigidbody>();
        startpos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingright)
        {
            platformvelo = platformrb.velocity;
            platformvelo.x += 3 * Time.deltaTime;
            platformrb.velocity = platformvelo;
            if(platformrb.transform.position.x>startpos.x+2.45f)
            {
                platformvelo = platformrb.velocity;
                platformvelo.x = 0;
                platformrb.velocity = platformvelo;
                movingright = false;
            }
        }
        else
        {
            platformvelo = platformrb.velocity;
            platformvelo.x -= 3 * Time.deltaTime;
            platformrb.velocity = platformvelo;
            if (platformrb.transform.position.x < startpos.x - 2.45f)
            {
                platformvelo = platformrb.velocity;
                platformvelo.x = 0;
                platformrb.velocity = platformvelo;
                movingright = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            AudioSource.PlayClipAtPoint(platformSound, transform.position, 0.7f);
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
