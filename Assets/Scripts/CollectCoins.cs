using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public int Coin = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {

            other.GetComponent<PlayerMovement>().Coin += 1;
            Destroy(gameObject);

        }
    }
}
