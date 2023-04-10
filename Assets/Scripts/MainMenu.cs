using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading;

public class MainMenu : MonoBehaviour
{

    public AudioClip Background;
    private AudioSource playerAudio;

    public void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerAudio.PlayOneShot(Background, 0.8f);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayGame2()
    {
        Thread.Sleep(5000);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
