using UnityEngine;
using TMPro;
public class ScoreBoard : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private int score = 0;

    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
