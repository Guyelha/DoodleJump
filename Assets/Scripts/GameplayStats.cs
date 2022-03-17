using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayStats : MonoBehaviour
{
    public Text ScoreText;
    public Text CoinText;
    public Text HighScoreText;
    public Text EnemyHighScoreText;
    
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        HighScoreText.text = "HighScore:" + PlayerPrefs.GetInt("HighScore").ToString();
        EnemyHighScoreText.text = "EnemyHighScore:" + PlayerPrefs.GetInt("EnemyHighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score:" + playerMovement.Score.ToString();
        CoinText.text = "Coins:" + playerMovement.Coin.ToString();
       

    }
}
