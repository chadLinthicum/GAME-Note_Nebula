using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading;

public class MainMenu : MonoBehaviour
{
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
