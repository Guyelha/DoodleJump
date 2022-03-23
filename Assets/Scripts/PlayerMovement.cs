using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float movementPower = 15;
    public int Score;
    public int Coin;
    public int HighScore;
   
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * movementPower;
        Vector3 newMovement = rb.velocity;
        newMovement.x = horizontalMovement;
        rb.velocity = newMovement;
        int checkScore = Mathf.RoundToInt(transform.position.y * 25);
        if (checkScore > Score)
            Score = checkScore;

        Quaternion characterRotation = Quaternion.Euler(0,0,0);
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterRotation.y = 180;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            characterRotation.y = 0;
        }
        transform.localRotation = characterRotation;
    }

   
}