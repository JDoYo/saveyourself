/*************************************************************************************/
/*	
/*	FILE NAME: Score.cs
/* 
/*	DESCRIPTION: Controls all of the scores in the game.
/* 			     
/* 	   DATE		        BY		              DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	10/21/2016	 Kristofer Oubre	Created the class and added all methods
/***************************************************************************************/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	// The textbox used for the score
	public Text scoreText;

	// The user's last score
	public static int score;

	// The user's best score
	public static int bestScore;

	// When this class is initialized, the best score is set to the last saved
	// BestScore value.
	void Start ()
	{
		bestScore = PlayerPrefs.GetInt ("BestScore", 0);
	}
	
	// During every frame, the score textbox is updated with the last score.
	void Update ()
	{
		scoreText.text = score.ToString ();
	}

	// When this class is disabled, the score is compared to the best score.
	// If the score is greater than the best score, the best score is updated.
	// Also, all scores are saved before resetting the score to 0.
	void OnDisable ()
	{
		if (score > bestScore) {
			PlayerPrefs.SetInt ("BestScore", score);
		}
		if (Multiplayer.multiplayerStep == 2) {
			PlayerPrefs.SetInt ("Player1Score", score);
			PlayerPrefs.Save ();
		} else if (Multiplayer.multiplayerStep == 1) {
			PlayerPrefs.SetInt ("Player2Score", score);
			PlayerPrefs.Save ();
		} else {
			PlayerPrefs.SetInt ("Score", score);
			PlayerPrefs.Save ();
		}
		score = 0;
	}
}
