using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {


	// -- Properties -- //

	// Nightmare count
	public int nightmaresTapped;

	// Dream count
	public int dreamsTapped;

	// Score
	public int score;

	// Nightmare score
	public int nightmareScore;

	// Dream score
	public int dreamScore;


	// GUIStyle
	private GUIStyle style;

	void  Update()
	{
		scoreTo ();
	}

	 public void scoreTo()
	{
		nightmareScore = nightmaresTapped * 10;
		dreamScore = dreamsTapped * 10;
		score = nightmareScore - dreamScore;
		if(score <= 0)
		{
			score = 0;
		}

	}
}
