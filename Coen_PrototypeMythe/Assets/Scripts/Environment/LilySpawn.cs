using UnityEngine;
using System.Collections;

public class LilySpawn : MonoBehaviour {	


	// -- Vars -- //

	// Delay
	private float delay = 6;

	void Update () 
	{
		// Timer
		delay -= Time.deltaTime;

		if(delay <= 0)
		{
			// Load Lily
			Instantiate(Resources.Load("Lily"),transform.position, Quaternion.identity);

			// New random delay
			delay = Random.Range(5f,11f);
		}
	}
}
