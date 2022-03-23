using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "HighScore:" + PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
