using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void PlayAgain()
    {


         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Tải lại scene bằng index
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void MainMenu()
    {
        // Tải scene chính (Main Menu)
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        // Thoát game
        Debug.Log("Quit Game!");
        Application.Quit();
    }
}
