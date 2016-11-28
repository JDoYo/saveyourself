/***************************************************************************************/
/*	
/*	FILE NAME: Achievements.cs
/* 
/*	DESCRIPTION: Retrieves and displays the user's best time and best score. 
/* 			     
/* 	  DATE			BY		              DESCRIPTION
/* 	=========	 ===============	========================================
/* 	10/24/2016	 Kristofer Oubre	Created the class and added Start method
/****************************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Achievements : MonoBehaviour
{
	// The textbox for the best time
	public Text bestTime;

	// The textbox for the best score
	public Text bestScore;

	// When this class is initialized, it retrieves the best time and best score
	// and places them in their appropriate textboxes.
	void Start ()
	{
		bestTime.text = PlayerPrefs.GetString ("BestTime", "0:00");
		bestScore.text = PlayerPrefs.GetInt ("BestScore", 0) + "";
	}
}
