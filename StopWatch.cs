/******************************************************************************/
/*	
/*	FILE NAME: StopWatch.cs
/* 
/*	DESCRIPTION: Controls the stopwatch in the game.
/* 			     
/* 	   DATE			   BY						   DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	10/21/2016	 Kristofer Oubre	Created the class and added all methods
/******************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StopWatch : MonoBehaviour
{
	// The amount of seconds the user has played
	public static int secondsPlayed = 0;

	// The textbox used for the time
	public Text timeAmount;

	// The textbox used for name of the multiplayer, either "Player 1" or "Player 2"
	public Text multiplayerName;

	// The textboxed used for the pause message
	public Text pauseMessage;

	// The pause button
	public GameObject pauseButton;

	// The play button
	public GameObject playButton;

	// Value used to determine if the game is paused
	public static bool isPaused = false;

	// The number of seconds that passed
	private int seconds = 0;

	// The number of minutes that passed
	private int minutes = 0;

	// The time in "0:00" format
	private string time;

	// The best time in "0:00" format
	private string bestTime;

	// When this class is initialized, the pause and play buttons are either
	// enabled or disabled based upon if the game is paused, and the multiplayerName
	// textbox is updated based upon if multiplayer mode is enabled and multiplayerStep
	// value.
	void Start ()
	{
		pauseButton.SetActive (true);
		playButton.SetActive (false);
		pauseMessage.text = "";
		bestTime = PlayerPrefs.GetString ("BestTime", "0:00");
		StartCoroutine ("PlayTimer");
		if (Multiplayer.multiplayerStep == 2) {
			multiplayerName.text = "Player 1";
		} else if (Multiplayer.multiplayerStep == 1) {
			multiplayerName.text = "Player 2";
		}
	}

	// This method updates the amount of seconds played and the time that is showed
	// while the game is being played.
	private IEnumerator PlayTimer ()
	{
		yield return new WaitForSeconds (3);
		while (true) {
			yield return new WaitForSeconds (1);
			secondsPlayed += 1;
			minutes = Mathf.FloorToInt (secondsPlayed / 60F);
			seconds = Mathf.FloorToInt (secondsPlayed - minutes * 60);
			time = string.Format ("{0:0}:{1:00}", minutes, seconds);
			timeAmount.text = time.ToString ();
		}
	}

	// During every frame, the isPaused value is checked. If the game is paused,
	// everything freezes and the game is not playable. If the game is not paused,
	// the game is playable.
	void Update ()
	{
		timeAmount.enabled = true;
		if (isPaused == true) {
			Time.timeScale = 0;
		} else if (isPaused == false) {
			Time.timeScale = 1;
		}
	}

	// This method is used to pause the game.
	public void pauseGame ()
	{
		isPaused = true;
		pauseButton.SetActive (false);
		playButton.SetActive (true);
		pauseMessage.text = "Game Paused";
		gameObject.GetComponent<AudioSource> ().Pause ();
	}

	// This method is used to resume the game.
	public void resumeGame ()
	{
		isPaused = false;
		pauseButton.SetActive (true);
		playButton.SetActive (false);
		pauseMessage.text = "";
		gameObject.GetComponent<AudioSource> ().Play ();
	}

	// When this class is disabled, all of the time values are saved and the
	// number of seconds played is set back to 0.
	void OnDisable ()
	{
		if (time.CompareTo (bestTime) == 1) {
			PlayerPrefs.SetString ("BestTime", time);
		}
		if (Multiplayer.multiplayerStep == 2) {
			PlayerPrefs.SetString ("Player1Time", time);
			Multiplayer.player1TimeAmount = secondsPlayed;
		} else if (Multiplayer.multiplayerStep == 1) {
			PlayerPrefs.SetString ("Player2Time", time);
			Multiplayer.player2TimeAmount = secondsPlayed;
		} else {
			PlayerPrefs.SetString ("Time", time);
		}
		PlayerPrefs.Save ();
		secondsPlayed = 0;
		isPaused = false;
	}
}
