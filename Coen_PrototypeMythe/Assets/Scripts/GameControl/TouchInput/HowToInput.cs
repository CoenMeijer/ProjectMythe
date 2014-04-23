using UnityEngine;
using System.Collections;

public class HowToInput : MonoBehaviour {

	public GameObject[] pages;
	public GameObject[] buttons;
	private int pageCount = 0;
	
	void Update () {
		if(Input.touchCount > 0)
		{
			
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit hit;
			if(Input.GetTouch(0).phase == TouchPhase.Began)
			{
				if(Physics.Raycast(ray, out hit))
				{
					if(hit.collider.name == "Next")
					{
						if(pageCount == 0)
						{
							pages[pageCount].SetActive(false);
							pageCount ++;
							buttons[1].SetActive(true);

						}
						else if(pageCount == 1)
						{
							pages[pageCount].SetActive(false);
							pageCount ++;
							buttons[0].SetActive(false);
							buttons[2].SetActive(true);
						}
					}
					else if(hit.collider.name == "Previous")
					{
						if(pageCount == 1){

							pageCount --;
							pages[pageCount].SetActive(true);
							buttons[1].SetActive(false);
						}
						else if(pageCount == 2)
						{
							pageCount --;
							pages[pageCount].SetActive(true);
							buttons[0].SetActive(true);
							buttons[2].SetActive(false);
						}
					}
					else if(hit.collider.name == "Back")
					{
						Application.LoadLevel(0);
					}
				}
			}
		}
	}
}
