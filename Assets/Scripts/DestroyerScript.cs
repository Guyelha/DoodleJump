using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    public GameObject lostCanvas;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BouncyPrefab>())
        {
            Destroy(other.gameObject);
        }

        if (other.GetComponent<PlarformScript>())
        {
            Destroy(other.gameObject);
        }

        if(other.GetComponent<ShiftingPlatform>())
        {
            Destroy(other.gameObject);
        }

        if (other.GetComponent<BreakingPlatform>())
        {
            Destroy(other.gameObject);
        }

        if (other.GetComponent<CollectCoins>())
        {
            Destroy(other.gameObject);
        }

        if (other.GetComponent<Enemy>())
        {
            Destroy(other.gameObject);
        }



    }
    private void OnTriggerExit(Collider other)
    {
        if(other.GetComponent<PlayerMovement>())
        {
            lostCanvas.SetActive(true);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
