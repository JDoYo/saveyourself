/******************************************************************************/
/*	
/*	FILE NAME: Countdown.cs
/* 
/*	DESCRIPTION: Controls the countdown that is displayed before the game starts.
/* 			     
/* 	   DATE			   BY						   DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	10/26/2016	 Kristofer Oubre	Created the class and added all methods
/******************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour
{
	// The countdown time
	public static int time = 3;

	// The textbox for the countdown
	public Text countdown;

	// When this class is initialized, countdownOver, which controls when the
	// the rocks can start moving toward the car, is set to false, and the Clock,
	// which decrements the time every second, is started.
	void Start ()
	{
		RockController.countdownOver = false;
		StartCoroutine ("Clock");
	}

	// Decrements the time every second, destroys the countdown when the time
	// reaches 0, and then sets the countdownOver value to true so the rocks can
	// start approaching the car.
	private IEnumerator Clock ()
	{
		while (true) {
			yield return new WaitForSeconds (1);
			time -= 1;
			countdown.text = time.ToString ();
			if (time == 0) {
				countdown.enabled = false;
				Destroy (gameObject);
				RockController.countdownOver = true;
			}
		}
	}

	// When this class is disabled, the time value is set back to 3.
	void OnDisable ()
	{
		time = 3;
	}
}
