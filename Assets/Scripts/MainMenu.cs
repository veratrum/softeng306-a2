﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        FindObjectOfType<AudioManager>().Play("Confirm");
        SceneManager.LoadScene("LevelSelectScene");
    }

    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("Confirm");
        Debug.Log("Quit game");
        Application.Quit();
        
    }
}
