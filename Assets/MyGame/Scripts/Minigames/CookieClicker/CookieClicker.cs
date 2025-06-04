
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CookieClicker : MonoBehaviour
{
    public Button clickButton;
    public Text scoreText;
    public Text timerText;
    public int targetScore = 100;      
    public float timeLimit = 10f;      
    private int currentScore = 0;
    private float timeLeft;

    void Start()
    {
        timeLeft = timeLimit;
        clickButton.onClick.AddListener(OnClickCookie);
        UpdateScoreText();
        UpdateTimerText();
    }

    void Update()
    {
        if (timeLeft > 0 && currentScore < targetScore)
        {
            timeLeft -= Time.deltaTime;
            UpdateTimerText();

            if (timeLeft <= 0)
            {
                timeLeft = 0;
                GameOver(false);
            }
        }
    }

    void OnClickCookie()
    {
        if (timeLeft > 0 && currentScore < targetScore)
        {
            currentScore++;
            UpdateScoreText();

            if (currentScore >= targetScore)
            {
                GameOver(true);
            }
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Punkte: " + currentScore;
    }

    void UpdateTimerText()
    {
        timerText.text = "Zeit: " + Mathf.CeilToInt(timeLeft);
    }

    void GameOver(bool success)
    {
        if (success)
        {
            //Szene wechseln
            SceneManager.LoadScene("NextLevel");
        }
        else
        {
            // Feedback 
            timerText.text = "Zeit abgelaufen!";
        }
    }
}
