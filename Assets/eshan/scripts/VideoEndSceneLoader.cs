// 1/11/2026 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEndSceneLoader : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component
    public string sceneToLoad; // Name of the scene to load after the video ends

    void Start()
    {
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += OnVideoEnd; // Subscribe to the event when the video ends
        }
        else
        {
            Debug.LogError("VideoPlayer component is not assigned or found!");
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(sceneToLoad); // Load the specified scene
    }
}
