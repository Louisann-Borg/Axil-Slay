using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static int CurrentScore = 0;

    private void Start()
    {
        CurrentScore = 0;
    }

    public void IncrementScore()
    {
        CurrentScore++;
        Text scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + CurrentScore.ToString();
    }

}
