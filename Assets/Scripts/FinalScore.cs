using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI Scoretext;
    [SerializeField] public TextMeshProUGUI Distancetext;
    private void Start()
    {
        Scoretext.text = ScoreKeeper.CurrentScore.ToString();
        Distancetext.text = ReverseTimer.CurrentTime.ToString();
    }
}