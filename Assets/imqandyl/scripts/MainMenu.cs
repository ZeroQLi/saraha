using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenu : MonoBehaviour
{
    public VideoPlayer introVideo;
    public AudioSource menuMusic;

    public void PlayGame()
    {
        // Stop menu music
        if (menuMusic != null)
            menuMusic.Stop();

        // Play intro video
        if (introVideo != null)
        {
            introVideo.gameObject.SetActive(true);
            introVideo.Play();
            introVideo.loopPointReached += OnVideoFinished;
        }
        else
        {
            // Fallback if video missing
            SceneManager.LoadScene("GameScene");
        }
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
