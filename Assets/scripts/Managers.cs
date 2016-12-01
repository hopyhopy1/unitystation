﻿using UnityEngine;
using System.Collections;
using UI;

public class Managers : MonoBehaviour {

	public static Managers control;
	// Use this for initialization

	[Header("For turning UI on and off to free up the editor window")] 

	public GameObject UIParent;


	void Awake(){

		if (control == null) {
		
			Application.runInBackground = true; // this must run in background or it will drop connection if not focussed.

			DontDestroyOnLoad (gameObject);
			control = this;
		
		} else {

			Destroy(gameObject);

		}

	}
	void Start () {
	
	}
		
	// Update is called once per frame
	void Update () {
	
	}

	public void SetScreenForGame(){ //Called by GameData

		UIParent.SetActive (true);
		UIManager.control.displayControl.SetScreenForGame ();

	}

	public void SetScreenForLobby(){ //Called by GameData
		UIParent.SetActive (true);
		UIManager.control.displayControl.SetScreenForLobby ();

	}
}
