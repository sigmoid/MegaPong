﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void NewGameBttn(string gameLevel)
    {
        SceneManager.LoadScene(gameLevel);
    }

    public void ExitGameBttn()
    {
        Application.Quit();
    }

}
