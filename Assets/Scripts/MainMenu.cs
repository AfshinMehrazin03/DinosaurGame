using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit!"); // این فقط توی ادیتور نشون داده میشه
    }
}
