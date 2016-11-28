/*************************************************************************************/
/*	
/*	FILE NAME: LoseValue.cs
/* 
/*	DESCRIPTION: Controls the car value that is displayed during the game and when
/* 	             the smoke and fire should be shown.
/* 			     
/* 	   DATE		       BY	                      DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	10/21/2016	 Kristofer Oubre	Created the class and added all methods
/*************************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class LoseValue : MonoBehaviour
{
	// The textbox used for the car value
	public Text carValue;

	// The smoke GameObject
	public GameObject smoke;

	// The fire GameObject
	public GameObject fire;

	// The value of the car
	public static double value = 27829.41;

	// When this class is initialized, the smoke and fire GameObjects are
	// disabled.
	void Start ()
	{
		fire.SetActive (false);
		smoke.SetActive (false);
	}
	
	// During every frame, the car value is checked. If value is less than
	// 15000, smoke is shown. If the value is less than 5000, fire is shown.
	// If the value is less than 5, the game is over and the screen is switched
	// to the GameOver scene.
	void Update ()
	{
		if (value < 0) {
			value = 0.0;
		}
		value = Math.Round (value, 2);
		carValue.text = value.ToString ();
		if (value < 15000) {
			smoke.SetActive (true);
		}
		if (value < 5000) {
			fire.SetActive (true);
		}
		if (value < 5) {
			SceneManager.LoadScene ("GameOver");
		}
	}

	// When this method is called, the car value is decreased by the amount
	// provided.
	public static void LoseVal (double amount)
	{
		value -= amount;
	}

	// When this class is disabled, the car value is reset.
	void OnDisable ()
	{
		value = 27829.41;
	}
}
