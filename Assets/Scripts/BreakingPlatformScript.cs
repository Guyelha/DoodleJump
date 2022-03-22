using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingPlatformScript : MonoBehaviour
{
    public GameObject leftCube;
    public GameObject rightCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BreakPlatform()
    {
        Rigidbody leftRB = leftCube.GetComponent<Rigidbody>();
        Rigidbody rightRB = rightCube.GetComponent<Rigidbody>();
        leftRB.isKinematic = false;
        rightRB.isKinematic = false;
        leftRB.useGravity = true;
        rightRB.useGravity = true;
        leftRB.AddForce(-20, 0, 0);
        rightRB.AddForce(20, 0, 0);
    }
}
