using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booleans : MonoBehaviour
{
	public bool isTrue;
	public bool isHappening;

	void Start()
	{
		isTrue = true;
		isHappening = true;
	}

	//checks every frame
	//not neccessarily a good way to check for things unless it needs to be checked all the time
	//e.g. updating numbers on the screen, or for health / stamina to give visual feedback to the player.
	void Update()
	{
		if (!isTrue) 
		{
			Debug.Log ("I'm Activated");
			isHappening = false;
		}

		if (isHappening) 
		{
			Debug.Log ("IsHappening");
		}
	}
}
