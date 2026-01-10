using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenu : MonoBehaviour
{
    public VideoPlayer introVideo;
    public AudioSource menuMusic;

   public void PlayGame()
{
    Debug.Log("PLAY BUTTON CLICKED");

    if (menuMusic != null)
        menuMusic.Stop();

    if (introVideo != null)
    {
        Debug.Log("VIDEO FOUND, PLAYING");
        introVideo.gameObject.SetActive(true);
        introVideo.Play();
        introVideo.loopPointReached += OnVideoFinished;
    }
    else
    {
        Debug.Log("NO VIDEO, LOADING SCENE");
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
