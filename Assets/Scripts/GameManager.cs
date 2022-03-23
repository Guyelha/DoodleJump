using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public Vector3 spawnPosition;
    public GameObject PlatformPrefab;
    public GameObject BouncyPrefab;
    public GameObject[] ShiftingPlatform;
    
    public GameObject BreakingPlatform2;
    public GameObject CoinPlatform;
    public GameObject[] EnemyPlatform;
    public GameObject lostCanvas;
    
   
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0;i <=5; i++)
        {
            CreatePlatform();
        }

    }

    // Update is called once per framed
    void Update()
    {
        if(playerTransform.position.y< 20)
        {
            if (playerTransform.position.y > spawnPosition.y - 15)
            {
                CreatePlatform();
            }
            if (playerTransform.position.y > spawnPosition.y - 15)
            {
                CreateBouncyPlatform();
            }
        }

        
        if(playerTransform.position.y> 30)
        {
            if (playerTransform.position.y > spawnPosition.y - 15)
            {
                CreateShiftingPlatform();
            }
        }


        if (playerTransform.position.y > 30)
        {
            if (playerTransform.position.y > spawnPosition.y - 15)
            {
                CreateCoinPlatform();
            }
        }



       


        if (playerTransform.position.y > 35)
        {
            if (playerTransform.position.y > spawnPosition.y - 15)
            {
                CreateBreakingPlatform2();

            }
        }


        if (playerTransform.position.y > 70)
        {
            if (playerTransform.position.y > spawnPosition.y - 15)
            {
                CreateEnemyPlatform();
                print("Spawned Enemy");
            }
        }







    }
    void CreatePlatform()
    {
        float randx = Random.Range(-2.75f,2.75f);
        float randy = Random.Range(0.5f, 2.7f);
        spawnPosition.y += randy;
        spawnPosition.x = randx;
        Instantiate(PlatformPrefab, spawnPosition, Quaternion.identity);
    
        
    }

    void CreateBouncyPlatform()
    {
        float randx = Random.Range(-2.75f, 2.75f);
        float randy = Random.Range(0.5f, 2.7f);
        spawnPosition.y += randy;
        spawnPosition.x = randx;
        Instantiate(BouncyPrefab, spawnPosition, Quaternion.identity);
    }
    void CreateShiftingPlatform()
    {
        int which = Random.Range(0, ShiftingPlatform.Length);
        float randx = Random.Range(-2.75f, 2.75f);
        float randy = Random.Range(0.5f, 2.7f);
        spawnPosition.y += randy;
        spawnPosition.x = randx;
        Instantiate(ShiftingPlatform[which], spawnPosition, Quaternion.identity);
    }

    void CreateCoinPlatform()
    {
        float randx = Random.Range(-2.75f, 2.75f);
        float randy = Random.Range(0.5f, 2.7f);
        spawnPosition.y += randy;
        spawnPosition.x = randx;
        Instantiate(CoinPlatform, spawnPosition, Quaternion.identity);
    }



 

    void CreateBreakingPlatform2()
    {
        float randx = Random.Range(-2.75f, 2.75f);
        float randy = Random.Range(0.5f, 2.7f);
        spawnPosition.y += randy;
        spawnPosition.x = randx;
        Instantiate(BreakingPlatform2, spawnPosition, Quaternion.identity);
    }

    void CreateEnemyPlatform()
    {
        int which = Random.Range(0,EnemyPlatform.Length);
        float randx = Random.Range(-2.75f, 2.75f);
        float randy = Random.Range(0.5f, 2.7f);
        spawnPosition.y += randy;
        spawnPosition.x = randx;
        Instantiate(EnemyPlatform[which], spawnPosition, Quaternion.identity);
    }

    public void LostGame()
    {
        Player.GetComponent<PlayerMovement>().enabled = false;
        Player.GetComponent<Rigidbody>().isKinematic = true;
        lostCanvas.SetActive(true);
    }


 
}
