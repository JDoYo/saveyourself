/*************************************************************************************/
/*	
/*	FILE NAME: CarSelection.cs
/* 
/*	DESCRIPTION: Controls which cars are shown on the CarSelection screen, saves
/* 		     the car that the user selects, and controls the help box on the
/* 		     CarSelection screen.
/* 			     
/* 	   DATE		      BY			     DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	10/22/2016	 Kristofer Oubre	Created the class and added all methods
/**************************************************************************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarSelection : MonoBehaviour
{
	// The left selection button
	public GameObject leftButton;

	// The right selection button
	public GameObject rightButton;

	// The index of the car that is displayed
	public static int carIndex = 0;

	// The index of the last car that the user chose
	public static int selectionIndex = 0;

	// The help box
	public GameObject helpBox;

	// The list of all the cars that the user can choose
	private List<GameObject> cars;

	// When this class is initialized, the last car the user chose is displayed
	// with a left and right button, when necessary. For example, if the user
	// chose the last car in the list the time before, the right button won't be
	// displayed. Also, a list of all the available cars (7 total) is made.
	void Start ()
	{
		if (selectionIndex == 0) {
			leftButton.SetActive (false);
			rightButton.SetActive (true);
		} else if (selectionIndex == 6) {
			leftButton.SetActive (true);
			rightButton.SetActive (false);
		}  
		cars = new List<GameObject> ();
		foreach (Transform t in transform) {
			cars.Add (t.gameObject);
			t.gameObject.SetActive (false);
		}
		cars [selectionIndex].SetActive (true);
		helpBox.SetActive (false);
	}

	// During every frame, the carIndex is checked and if the value is 1-5, both
	// the left and right buttons are displayed.
	void Update ()
	{
		if (carIndex > 0 && carIndex < 6) {
			leftButton.SetActive (true);
			rightButton.SetActive (true);
		}
	}

	// This method is called whenever the user clicks the left or right button.
	// If the first car in the list is displayed, the left button is disabled. If
	// the last in the list is displayed, the right button is disabled. Also,
	// whenever the left or right button is clicked, the selectionIndex is updated.
	public void Select ()
	{
		string name = EventSystem.current.currentSelectedGameObject.name;
		if (name == "Left") {
			carIndex -= 1;
			if (carIndex <= 0) {
				carIndex = 0;
				leftButton.SetActive (false);
			}
		} 
		if (name == "Right") {
			carIndex += 1;
			if (carIndex >= 6) {
				carIndex = 6;
				rightButton.SetActive (false);
			}
		} else if (carIndex == selectionIndex) {
			return;
		} else if (carIndex < 0 || carIndex >= cars.Count) {
			return;
		}
		cars [selectionIndex].SetActive (false);
		selectionIndex = carIndex;
		cars [selectionIndex].SetActive (true);
	}

	// Shows the help box.
	public void ShowHelp ()
	{
		helpBox.SetActive (true);
	}

	// Hides the help box.
	public void HideHelp ()
	{
		helpBox.SetActive (false);
	}

	// Saves the car that the user chose so it can be retrieved at a later time.
	public void SaveCar ()
	{
		PlayerPrefs.SetInt ("Car", selectionIndex);
		PlayerPrefs.Save ();
	}
}
