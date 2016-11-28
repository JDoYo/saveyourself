/******************************************************************************/
/*	
/*	FILE NAME: SoundVolume.cs
/* 
/*	DESCRIPTION: Controls the volume of the button sounds based upon the user's
/*               settings.
/* 			     
/* 	   DATE			   BY						   DESCRIPTION
/* 	==========	 ===============	=======================================
/* 	11/1/2016	 Kristofer Oubre	Created the class and added all methods
/******************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SoundVolume : MonoBehaviour
{

	// The button sound volume amount
	private float Vol;

	// When this class is initialized, the sound volume slider is updated to its
	// last saved value and the volume is set to that amount.
	void Start ()
	{
		GameObject.Find ("Sound Slider").GetComponent<Slider> ().value = PlayerPrefs.GetFloat ("SoundVolume", 1);
		Vol = PlayerPrefs.GetFloat ("SoundVolume", 1);
		ButtonSoundPlayer.volume = Vol;
	}

	// This method is used to change the button sound volume. When this method is
	// called, the volume is changed to the provided amount and the amount is saved.
	public void SetVolume (float vol)
	{
		ButtonSoundPlayer.volume = vol;
		PlayerPrefs.SetFloat ("SoundVolume", vol);
	}
}
