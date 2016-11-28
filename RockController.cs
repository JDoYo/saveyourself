/******************************************************************************/
/*	
/*	FILE NAME: RockController.cs
/* 
/*	DESCRIPTION: Controls the speed, direction, and location of the rocks. It
 * 				 also determines the amount to decrement the car value by.
/* 			     
/* 	   DATE			   BY						   DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	10/21/2016	 Kristofer Oubre	Created the class and added all methods
/******************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RockController : MonoBehaviour
{
	// Value used to determine when the game countdown is over
	public static bool countdownOver;

	// The car's transform
	private Transform car;

	// The rock's transform
	private Transform rock;

	// The start position of the rock
	private Vector3 startPosition;

	// The rock's move speed
	private int moveSpeed;

	// The rock's rotation speed
	private int rotationSpeed = 3;

	// An random x coordinate
	private float x;

	// Before the Start method is called, the rock's transform is set equal to
	// the transform of the GameObject attached to this class.
	// P.S.
	// Transform is used to control the position, rotation, and scale of an object.
	void Awake ()
	{
		rock = transform;
	}

	// When this class is initialized, the rock's x coordinate and move speed is randomized.
	// Also, the car transform is set to that of the invisible collision wall that's inside
	// the car.
	void Start ()
	{
		x = Random.Range (-7, 7);
		startPosition = new Vector3 ((rock.position.x + x), (rock.position.y), (rock.position.z));
		car = GameObject.FindWithTag ("Wall").transform;
		moveSpeed = Random.Range (3, 5);

	}

	// During every frame when the countdown is over, the rock's position and rotation is updated.
	void Update ()
	{
		if (countdownOver == true) {
			// rotate to look at car
			rock.rotation = Quaternion.Slerp (rock.rotation, Quaternion.LookRotation (car.position - rock.position), rotationSpeed * Time.deltaTime);
			transform.Rotate (0, 0, -360 * Time.deltaTime); // spin
			rock.position += rock.forward * moveSpeed * Time.deltaTime; // approach and hit car
		}
	}

	// This method is called when the rock collides with the invisible wall that's inside the car.
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Wall") {
			int num;
			num = Random.Range (0, 10);
			if (num == 0) {
				LoseValue.LoseVal (763.85);
			} else if (num == 1) {
				LoseValue.LoseVal (1434.91);
			} else if (num == 2) {
				LoseValue.LoseVal (972.13);
			} else if (num == 3) {
				LoseValue.LoseVal (1825.96);
			} else if (num == 4) {
				LoseValue.LoseVal (1636.72);
			} else if (num == 5) {
				LoseValue.LoseVal (1362.59);
			} else if (num == 6) {
				LoseValue.LoseVal (621.33);
			} else if (num == 7) {
				LoseValue.LoseVal (1284.23);
			} else if (num == 8) {
				LoseValue.LoseVal (2082.16);
			} else if (num == 9) {
				LoseValue.LoseVal (832.51);
			} else if (num == 10) {
				LoseValue.LoseVal (1201.66);
			}
		}
		Renew ();
	}

	// When this method is called, the rock is deleted and a clone of the rock is created
	// and given the start position.
	void Renew ()
	{
		GameObject old = gameObject;
		Instantiate (old, startPosition, transform.rotation);
		Destroy (old);
	}
}
