﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class exit : MonoBehaviour {
	private float game;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Application.Quit ();
		if (Input.GetKeyDown (KeyCode.R))
			SceneManager.LoadScene ("game");
	}
}
