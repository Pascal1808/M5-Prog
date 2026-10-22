using UnityEngine;
using TMPro;
public class ScoreBoard : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;

    void Start()
    {
        Hit.OnHit += AddScore;
    }

    public void AddScore()
    {
        score += 50;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

}
    
