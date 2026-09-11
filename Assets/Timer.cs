using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeUntilLose = 15.0f;
    [SerializeField] TMP_Text timerDisplay;

    bool gameActive = true;
    float timeRemaining;

    private void Start()
    {
        timeRemaining = timeUntilLose;
    }
    private void Update()
    {
        if (!gameActive) return;
        timeRemaining -= Time.deltaTime;
        timerDisplay.text = "Time Left: " + timeRemaining.ToString("F2");
        if (timeRemaining <= 0)
        {
            Debug.Log("You lose!");
            gameActive = false;
        }

    }
}
