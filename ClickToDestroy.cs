/*************************************************************************************/
/*	
/*	FILE NAME: ClickToDestroy.cs
/* 
/*	DESCRIPTION: Removes rocks from the game when they're clicked, creates a
/* 		     clone of them, and updates the score after the removal.
/* 			     
/* 	   DATE		       BY			     DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	10/21/2016	 Kristofer Oubre	Created the class and added all methods
/*************************************************************************************/

using UnityEngine;
using System.Collections;

public class ClickToDestroy : MonoBehaviour
{
	// The rock's transform
	private Transform rock;

	// The start position of the rock
	private Vector3 startPosition;

	// Before the Start method is called, the rock's transform is set equal to
	// the transform of the GameObject attached to this class.
	// P.S.
	// Transform is used to control the position, rotation, and scale of an object.
	void Awake ()
	{
		rock = transform;
	}

	// When this class is initialized, startPosition is set equal to the rock's
	// initial position.
	void Start ()
	{
		startPosition = rock.position;
	}

	// When the rock is clicked while the game isn't paused, the rock is deleted,
	// a clone is created and given the startPosition, and the score is updated.
	void OnMouseDown ()
	{
		if (StopWatch.isPaused == false) {
			GameObject old = gameObject;
			Instantiate (old, startPosition, transform.rotation);
			Destroy (old);
			Score.score += 1;
		}
	}
}
