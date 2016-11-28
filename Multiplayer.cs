/*************************************************************************************/
/*	
/*	FILE NAME: Multiplayer.cs
/* 
/*	DESCRIPTION: Controls the multiplayer mode.
/* 			     
/* 	   DATE		       BY	                      DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	11/1/2016	 Kristofer Oubre	Created the class and added all methods
/**************************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Multiplayer : MonoBehaviour
{
	// The step that multiplayer mode is on. If the value is equal to 0,
	// multiplayer mode is disabled.
	public static int multiplayerStep = 0;

	// Player 1's time
	public static int player1TimeAmount;

	// Player 2's time
	public static int player2TimeAmount;

	// The textbox for Player 1's time
	public Text player1Time;

	// The textbox for Player 1's score
	public Text player1Score;

	// The textbox for Player 2's time
	public Text player2Time;

	// The textbox for Player 2's score
	public Text player2Score;

	// The textbox for that message that shows when it's Player 2's turn and
	// the winner of the challenge.
	public Text message;

	// The stats panel used for single player mode
	public GameObject singlePlayerPanel;

	// Player 1's stats panel
	public GameObject player1Panel;

	// Player 2's stats panel
	public GameObject player2Panel;

	// The buttons used for single player mode
	public GameObject singlePlayerButtons;

	// The buttons used for multiplayer mode
	public GameObject multiPlayerButtons;

	// The sum of Player 1's time and score
	private int player1Total;

	// The sum of Player 2's time and score
	private int player2Total;

	// When this class is initialized, the panels, buttons, and textboxes are
	// either updated, enabled, or disabled based upon the step that
	// multiplayer mode is on.
	void Start ()
	{
		if (multiplayerStep > 0) {
			singlePlayerPanel.SetActive (false);
			player1Panel.SetActive (true);
			player2Panel.SetActive (true);
			if (multiplayerStep == 2) {
				singlePlayerButtons.SetActive (false);
				multiPlayerButtons.SetActive (true);
				player1Time.text = PlayerPrefs.GetString ("Player1Time");
				player1Score.text = PlayerPrefs.GetInt ("Player1Score") + "";
				player2Score.text = "";
				message.text = "Player 2's Turn";
				multiplayerStep = 1;
			} else if (multiplayerStep == 1) {
				singlePlayerButtons.SetActive (true);
				multiPlayerButtons.SetActive (false);
				player1Time.text = PlayerPrefs.GetString ("Player1Time");
				player1Score.text = PlayerPrefs.GetInt ("Player1Score") + "";
				player2Time.text = PlayerPrefs.GetString ("Player2Time");
				player2Score.text = PlayerPrefs.GetInt ("Player2Score") + "";
				player1Total = player1TimeAmount + PlayerPrefs.GetInt ("Player1Score");
				player2Total = player2TimeAmount + PlayerPrefs.GetInt ("Player2Score");
				if (player1Total > player2Total) {
					message.text = "Player 1 Wins!";
				} else if (player1Total < player2Total) {
					message.text = "Player 2 Wins!";
				} else {
					message.text = "Tie!";
				}
				multiplayerStep = 0;
			}
		} else {
			singlePlayerPanel.SetActive (true);
			singlePlayerButtons.SetActive (true);
			multiPlayerButtons.SetActive (false);
			player1Panel.SetActive (false);
			player2Panel.SetActive (false);
		}
	}
}
