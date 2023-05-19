using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReverseTimer : MonoBehaviour
{
    public static float CurrentTime; // Current time in seconds
    
    [SerializeField] 
    private TextMeshProUGUI timerText; // Reference to the Text component

    private void Start()
    {
        CurrentTime = 0;
    }

    void Update()
    {
        CurrentTime += Time.deltaTime;
        timerText.text = CurrentTime.ToString("0.00m");
    }

}

