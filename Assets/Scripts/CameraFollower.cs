using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform playerTransform;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.y - playerTransform.position.y;  
    }

    // Update is called once per frame
    void Update()
    {
        float newYPosition = playerTransform.position.y + offset;
        if(newYPosition>transform.position.y)
        transform.position = new Vector3(transform.position.x,newYPosition, transform.position.z);

    }
}
