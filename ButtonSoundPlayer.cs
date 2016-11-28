/******************************************************************************/
/*	
/*	FILE NAME: ButtonSoundPlayer.cs
/* 
/*	DESCRIPTION: Controls the sound and volume of the buttons.
/* 			     
/* 	  DATE			   BY						   DESCRIPTION
/* 	=========	 ===============	=======================================
/* 	11/1/2016	 Kristofer Oubre	Created the class and added all methods
/******************************************************************************/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(Button))]
public class ButtonSoundPlayer : MonoBehaviour
{
	// The sound of the buttons
	public AudioClip sound;

	// The volume of the button sound
	public static float volume = 1;

	// The button being used
	private Button button { get { return GetComponent <Button> (); } }

	// The audio source that plays the button sound
	private AudioSource source { get { return GetComponent <AudioSource> (); } }

	// When this class is initialized, it sets the button volume to the last saved
	// value and sets up the audio source that will play the button sound.
	void Start ()
	{
		volume = PlayerPrefs.GetFloat ("SoundVolume", 1);
		gameObject.AddComponent <AudioSource> ();
		source.clip = sound;
		source.playOnAwake = false;
		button.onClick.AddListener (() => PlaySound ());
	}

	// Plays the button sound when the button is clicked.
	void PlaySound ()
	{
		if (gameObject.activeSelf == true) {
			source.PlayOneShot (sound, volume);
		}
	}
}
