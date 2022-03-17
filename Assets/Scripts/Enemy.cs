using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject lostCanvas;

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            lostCanvas.SetActive(true);
            int highScore = other.GetComponent<PlayerMovement>().Score;
            if (highScore > PlayerPrefs.GetInt("EnemyHiighScore"))
            {
                PlayerPrefs.SetInt("EnemyHighScore", highScore);
            }

        }
    }

}
