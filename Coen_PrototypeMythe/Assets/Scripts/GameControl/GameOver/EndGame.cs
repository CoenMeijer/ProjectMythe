using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	// -- Properties -- //

	// GameObjects - 
	public GameObject game;

	// Endscreen
	public GameObject endScreen;

	// Gamecontrol
	public GameObject control;


	// -- Vars -- //

	// Player
	private GameObject player;

	// Scripts
	private LifeScript lifeP;
	private Score score;


	void Start () 
	{
		// Load GameObjects and Scripts
		player	= 	GameObject.Find ("CenterObject");
		lifeP 	= 	player.gameObject.GetComponent<LifeScript> ();
		score 	= 	control.gameObject.GetComponent<Score> ();

		// Set active
		game.SetActive (true);
		endScreen.SetActive (false);
	
	}

	void Update () 
	{
		if (lifeP.lifes == 0 || lifeP.lifes <= 0)
		{
			game.SetActive(false);
			endScreen.SetActive(true);
		}
	}
}
