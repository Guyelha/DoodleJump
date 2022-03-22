using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public int Coin = 0;
    public AudioClip coinSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {

            other.GetComponent<PlayerMovement>().Coin += 1;
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(coinSound, transform.position,0.7f);

        }
    }
}
