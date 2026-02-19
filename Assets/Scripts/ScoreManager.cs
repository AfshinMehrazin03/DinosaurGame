using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    private float score = 0;
    private float highScore = 0;
    private GameManager gameManager;
    
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
        UpdateHighScoreText();
    }
    
    void Update()
    {
        if (gameManager.isGameActive)
        {
            score += Time.deltaTime * 10;
            scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        }
    }
    
    public void GameOver()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("HighScore", highScore);
            UpdateHighScoreText();
        }
    }
    
    void UpdateHighScoreText()
    {
        if (highScoreText != null)
            highScoreText.text = "Best: " + Mathf.FloorToInt(highScore).ToString();
    }
    
    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score: 0";
    }
}
