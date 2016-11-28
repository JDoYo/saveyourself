/******************************************************************************/
/*	
/*	FILE NAME: MusicVolume.cs
/* 
/*	DESCRIPTION: Controls the volume of the game music based upon the user's
 * 				 settings.
/* 			     
/* 	   DATE			   BY						   DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	11/1/2016	 Kristofer Oubre	Created the class and added all methods
/******************************************************************************/

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MusicVolume : MonoBehaviour
{

	// The audio source used to play the music
	public AudioSource music;

	// Value used to determine if the volume has been changed
	private static bool volChanged = false;

	// When this class is initialized, if the scene name is "Options," the slider
	// used for the music is moved to its last saved place. Also, the music volume
	// is changed to its last saved amount.
	void Start ()
	{
		if (SceneManager.GetActiveScene ().name == "Options") {	
			GameObject.Find ("Music Slider").GetComponent<Slider> ().value = PlayerPrefs.GetFloat ("MusicVolume", 1);
		}
		music.volume = PlayerPrefs.GetFloat ("MusicVolume", 1);
	}

	// During every frame, the volChanged value is checked. If the volume has been
	// changed, the music volume is changed to that amount.
	void Update ()
	{
		if (volChanged == true) {
			music.volume = PlayerPrefs.GetFloat ("MusicVolume", 1);
		}
	}

	// This method is used to change the music volume. When this method is called, the
	// volume is changed to the provided amount and the amount is saved.
	public void SetVolume (float vol)
	{
		music.volume = vol;
		PlayerPrefs.SetFloat ("MusicVolume", vol);
		volChanged = true;
	}
}
