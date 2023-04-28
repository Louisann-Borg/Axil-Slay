using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI Scoretext;
    
    private void Start()
    {
        Scoretext.text = ScoreKeeper.CurrentScore.ToString();
    }
}
