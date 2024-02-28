using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int score=0;
    public Text scoreText;

    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }
}
