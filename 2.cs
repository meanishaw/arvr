using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    [Header("Keyboard Controls (for testing)")]
    public KeyCode playPauseKey = KeyCode.Space;
    public KeyCode stopKey = KeyCode.S;

    void Start()
    {
        if (videoPlayer != null)
        {
            videoPlayer.playOnAwake = false;
            videoPlayer.Stop();
        }
    }

    void Update()
    {
        if (videoPlayer == null) return;

       
        if (Input.GetKeyDown(playPauseKey))
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
            else
            {
                
                videoPlayer.Play();
            }
        }

 
        if (Input.GetKeyDown(stopKey))
        {
            StopVideo();
        }
    }

    public void PlayVideo()
    {
        if (videoPlayer == null) return;

       
        videoPlayer.Play();
    }

    public void PauseVideo()
    {
        if (videoPlayer == null) return;

        videoPlayer.Pause();
    }

    public void StopVideo()
    {
        if (videoPlayer == null) return;

        videoPlayer.Stop();
      
        videoPlayer.time = 0;
    }
}
