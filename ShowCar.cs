/*************************************************************************************/
/*	
/*	FILE NAME: ShowCar.cs
/* 
/*	DESCRIPTION: Controls which car is shown during the game based upon the car
/* 	             that the user selected.
/* 			     
/* 	   DATE		        BY			     DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	10/22/2016	 Kristofer Oubre	Created the class and added all methods
/**************************************************************************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ShowCar : MonoBehaviour
{
	// The index of the car that the user selected
	private int selectionIndex;

	// The list of the available cars to choose from
	private List<GameObject> cars;

	// When this class is initialized, the game shows the car that the user
	// selected on the CarSelection screen
	void Start ()
	{
		selectionIndex = CarSelection.selectionIndex;
		cars = new List<GameObject> ();
		foreach (Transform t in transform) {
			cars.Add (t.gameObject);
			t.gameObject.SetActive (false);
		}
		cars [selectionIndex].SetActive (true);
	}
}
