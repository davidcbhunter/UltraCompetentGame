﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuUi : MonoBehaviour
{
    public void QuitButton() => Application.Quit();
    public void PlayButton() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   
}
