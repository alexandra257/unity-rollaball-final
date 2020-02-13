using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushHint: MonoBehaviour {

	public GameObject ui;

	// Use this for initialization
	void Start () 
	{
		//sets UI as inactive  (invisible) until it is later triggered)
		ui.SetActive(false);
	}
		
		void OnTriggerStay(Collider other)
	{
		//if player collides, set the UI text to visible (Active)
		if (other.gameObject.tag == ("Player")) {
			ui.SetActive (true);
		}

	}

	void OnTriggerExit()
	//when the player leaves the trigger, turn UI text off
	{
		ui.SetActive (false);
	}
}
