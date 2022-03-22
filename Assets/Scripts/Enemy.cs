using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public AudioClip bombSound;


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            AudioSource.PlayClipAtPoint(bombSound, transform.position, 0.7f);

            FindObjectOfType<GameManager>().LostGame();
            int highScore = other.GetComponent<PlayerMovement>().Score;
            if (highScore > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore:", highScore);
            }

        }
    }

}
