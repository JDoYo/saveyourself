/************************************************************************************/
/*	
/*	FILE NAME: MusicPlayer.cs
/* 
/*	DESCRIPTION: Controls the sound and volume of the game music.
/* 			     
/* 	   DATE		       BY			     DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	11/1/2016	 Kristofer Oubre	Created the class and added all methods
/*************************************************************************************/

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
	// The audio source used to play the music
	public AudioSource music;

	// Value used to determine when the music has already started playing
	private static bool musicStarted = false;

	// Before the start method is called, the music is played, if it isn't
	// already playing.
	void Awake ()
	{
		if (!musicStarted) {
			music.Play ();
			DontDestroyOnLoad (gameObject);
			musicStarted = true;
		}
	}

	// When this class is initialized, the music AudioSource is set to the
	// audio source that is attached to this class.
	void Start ()
	{
		music = GetComponent<AudioSource> ();
	}
		
	// During every frame, the name of the scene is checked. If the scene
	// is "Game" or "GameOver," the music is stopped. This used because the
	// "Game" and "GameOver" scenes have their own music.
	void Update ()
	{
		if (SceneManager.GetActiveScene ().name == "Game" || SceneManager.GetActiveScene ().name == "GameOver") {
			music.Stop ();
			musicStarted = false;
		}
	}
}
