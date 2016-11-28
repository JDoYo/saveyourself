/******************************************************************************/
/*	
/*	FILE NAME: GameOver.cs
/* 
/*	DESCRIPTION: Displays the score and time from the last game played.
/* 			     
/* 	   DATE			   BY						   DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	10/23/2016	 Kristofer Oubre	Created the class and added all methods
/******************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour
{
	// The Textbox used for the score
	public Text score;

	// The TextBox used for the time
	public Text time;

	// When this class is initialized, the score and time textboxes are
	// set to the last score and time that were saved.
	void Start ()
	{
		score.text = PlayerPrefs.GetInt ("Score") + "";
		time.text = PlayerPrefs.GetString ("Time");
	}
}
