using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenu : MonoBehaviour
{
    public VideoPlayer introVideo;
    public GameObject introVideoUI;
    public AudioSource menuMusic;

    bool isPlaying = false;

    public void PlayGame()
    {
        if (isPlaying) return;
        isPlaying = true;

        // Stop menu music
        if (menuMusic != null)
            menuMusic.Stop();

        // Show video UI
        introVideoUI.SetActive(true);

        // Play video
        introVideo.loopPointReached -= OnVideoFinished;
        introVideo.loopPointReached += OnVideoFinished;
        introVideo.Play();
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
