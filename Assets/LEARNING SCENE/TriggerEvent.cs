using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script deactivates cubes 

public class TriggerEvent : MonoBehaviour 
{
	public GameObject cube1;
	public GameObject cube2;


	public bool cubeBool;


	void OnTriggerEnter (Collider other)
	{
		//when we walk into the trigger
		if(other.CompareTag("Player"))
		{
			//set cubeBool to true
			cubeBool = true;
			//run Cubes
			Cubes ();
	}
}

	void Cubes()
{
		//is it true?
	if (cubeBool)
		{
			//yes, so deactivate both cubes
		cube1.SetActive(false);
		cube2.SetActive(false);

		}
	}
}


/*//when the player collides with the trigger
if (other.CompareTag ("Player")) {
	//and if cubeBool is set to true, set cube1 to false (deactivate) 
	if (cubeBool) {
		cube1.SetActive (false);
	} else {
		//and if cubeBool is set to false, set cube2 to false (deactivate)
		cube2.SetActive (false);
	}*/

		
