/*************************************************************************************/
/*	
/*	FILE NAME: ChangeScenes.cs
/* 
/*	DESCRIPTION: Changes the scenes, or screens, enables multiplayer, and exits
/* 		     the app.
/* 			     
/* 	   DATE		       BY	                      DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	10/22/2016	 Kristofer Oubre	Created the class and added all methods
/**************************************************************************************/

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
	// Switches to a new scene based on the name provided.
	public void SwitchScene (string SceneName)
	{
		SceneManager.LoadScene (SceneName);
	}

	// This method enables multiplayer mode. When multiplayerStep is equal to 2,
	// it means multiplayer mode has just started. The value is decremented in the
	// Multiplayer class after each step has been completed. Then when it reaches
	// 0, multiplayer mode is no longer active.
	// P.S.
	// This method is only in this class because this is the only way to enable
	// multiplayer mode from a scene that doesn't have access to the Multiplayer
	// class. It works in this situation because this class can be accessed from
	// every scene, therefore it can access the Multiplayer class from the scene
	// that has both classes.
	public void playMultiplayer ()
	{
		Multiplayer.multiplayerStep = 2;
	}

	// Exits the app.
	public void Quit ()
	{
		Application.Quit ();
	}
}
