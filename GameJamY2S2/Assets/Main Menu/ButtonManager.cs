﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour 
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void NewGameButton(string startLevel)
		{
			SceneManager.LoadScene(startLevel);
		}	

	public void ExitGameButton()
	{
		Application.Quit();
	}
}
