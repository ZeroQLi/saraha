using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public AudioSource menuMusic;
    public GameObject gameOverScreen;
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        if (menuMusic != null)
            menuMusic.Stop();
        gameOverScreen.SetActive(true);
    }
}
