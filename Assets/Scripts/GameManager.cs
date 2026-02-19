using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameActive = false;
    public GameObject gameOverPanel;
    public ScoreManager scoreManager;
    
    void Start()
    {
        isGameActive = true;
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }
    
    public void GameOver()
    {
        isGameActive = false;
        scoreManager.GameOver();
        
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
