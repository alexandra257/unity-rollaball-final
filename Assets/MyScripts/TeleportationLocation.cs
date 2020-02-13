using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationLocation : MonoBehaviour {

	public GameObject ui;
	public GameObject objToTp;
	public Transform tpLoc;


	// Use this for initialization
	void Start () 
	{
		//sets UI text to inactive
		ui.SetActive(false);
	}


		void OnTriggerStay(Collider other)
	{
		//display UI text
		ui.SetActive (true);

		//if the player collides, and we press the 'E' key
		if ((other.gameObject.tag == "Player") && Input.GetKeyDown (KeyCode.E)) 
		{
			//object teleport to set location in inspector
			objToTp.transform.position = tpLoc.transform.position;
		}
	}

	void OnTriggerExit()
	{
		//when player exits the trigger, set UI text to inactive
		ui.SetActive (false);
	}
}
