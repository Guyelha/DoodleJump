using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    
  
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
        int highScore = other.GetComponent<PlayerMovement>().Score;
        if (highScore > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", highScore);
        }

        if (other.GetComponent<PlayerMovement>())
        {

            FindObjectOfType<GameManager>().LostGame();
         

            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
