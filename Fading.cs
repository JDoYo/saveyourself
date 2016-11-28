/************************************************************************************/
/*	
/*	FILE NAME: Fading.cs
/* 
/*	DESCRIPTION: Controls the fade in that appears when a new scene, or screen,
/*                   is loaded.
/* 			     
/* 	   DATE		        BY	                    DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	10/30/2016	 Kristofer Oubre	Created the class and added all methods
/*************************************************************************************/

using UnityEngine;
using System.Collections;

public class Fading : MonoBehaviour
{
	// The texture that will overlay the screen. Can be a black image.
	public Texture2D fadeOutTexture;

	// The fading speed
	public float fadeSpeed = 0.8f;

	// The texture's order in the draw hierarchy: a low number means it renders on top
	private int drawDepth = -1000;

	// The texture's alpha value between 0 and 1
	private float alpha = 1.0f;

	// The direction to fade: in = -1 or out = 1
	private int fadeDir = -1;

	// Controls what is displayed on the screen.
	void OnGUI ()
	{
		// fade out/in the alpha value using a direction, a speed and Time.deltaTime to convert the operation to seconds
		alpha += fadeDir * fadeSpeed * Time.deltaTime;

		// force (clamp) the number to be between 0 and 1 because GUI.color uses Alpha values between 0 and 1
		alpha = Mathf.Clamp01 (alpha);

		// set color of our GUI (in this case our texture). All color values remain the same & the Alpha is set to the alpha variable
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawDepth; // make the black texture render on top (drawn last)
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture); // draw the texture to fit the entire screen area
	}

	// Sets fadeDir to the direction parameter making the scene fade in if -1 and out if 1.
	public float BeginFade (int direction)
	{
		fadeDir = direction;
		return (fadeSpeed);
	}

	// OnLevelWasLoaded is called when a level is loaded. It takes loaded level index (int)
	// as a parameter so you can limit the fade in to certain scenes.
	void OnLevelWasLoaded ()
	{
		// alpha = 1;		// use this if the alpha is not set to 1 by default
		BeginFade (-1);		// call the fade in function
	}
}
