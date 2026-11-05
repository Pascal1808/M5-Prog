using UnityEngine;
using System;
using TMPro;
 
public class Scoreboard : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
   
    void OnEnable()
{
    Hit.OnPickupCollected += AddScore;
}
 
void AddScore()
{
    score += 50;
    UpdateScoreText();
}
void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    void OnDisable()
    {
        Hit.OnPickupCollected -= AddScore;
    }
}
    
