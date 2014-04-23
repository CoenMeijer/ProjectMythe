using UnityEngine;
using System.Collections;

public class LilyMovement : MonoBehaviour {


	// -- Vars -- //

	// Position
	private Vector3 pos;

	// Scale
	private Vector3 scale;
	
	void Start () 
	{
		// Random position
		pos = new Vector3(11f, Random.Range(-2f, -4.5f), 14.05f);

		// Random scale
		scale = new Vector3(Random.Range(0.5f,1f),Random.Range(0.5f,1f),1);
		
		transform.position = pos;
		transform.localScale = scale;
	}
	

	void Update () 
	{
		// Move left
		transform.Translate(Vector3.left * Time.deltaTime);

		// Destroy 
		if(transform.position.x <= -12.5f)
		{
			Destroy(gameObject);
		}
	}
}
