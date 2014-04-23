using UnityEngine;
using System.Collections;

public class FadeScript	: MonoBehaviour
{
	// -- Properties -- //

	// Texture
	public Texture2D Fadetexture;

	// Fade Boolean
	public bool fadingOut = false;

	// Fade value
	public float alphaFadeValue = 0;

	// Fade Speed
	public float fadeSpeed = 1.5f;

	void Start ()
	{
		if (Fadetexture == null) 
		{
			Fadetexture = new Texture2D (1, 0);
			Fadetexture.SetPixel (1, 1, new Color (1, 1, 1, 1));
		}
	}

	void OnGUI()
	{
		GUI.depth = 1;
		alphaFadeValue = Mathf.Clamp01 (alphaFadeValue + ((Time.deltaTime / fadeSpeed) * (fadingOut ? 1 : -1)));
		if (alphaFadeValue != 0) 
		{
			GUI.color = new Color (1, 1, 1, alphaFadeValue);
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), Fadetexture);
		}
	}
}