using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text highScoreText;

    private int highScore;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + highScore.ToString();
    }

    public void UpdateHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoreText.text = "High Score: " + highScore.ToString();
        }
    }

    public class GameController : MonoBehaviour
{
    public HighScoreManager highScoreManager;

    private int score;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        // Update the score here...
    }

    void GameOver()
    {
        highScoreManager.UpdateHighScore(score);
    }
}
}
