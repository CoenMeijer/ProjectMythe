using UnityEngine;
using System.Collections;

public class DreamScript : MonoBehaviour {


	// -- Properties -- //

	// Sound
	public AudioClip sound;

	// Range
	public bool inRange = false;


	// Audio function
	public void DeathSound()
	{
		AudioSource.PlayClipAtPoint(sound, transform.position);
	}
}
