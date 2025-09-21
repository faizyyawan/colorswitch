using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject endScreenCanvas;

    public void ShowEndScreen()
    {
        Time.timeScale = 0f; // freeze game (optional)
        endScreenCanvas.SetActive(true);
    }

    public void ResetGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
