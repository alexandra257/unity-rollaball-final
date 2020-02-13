using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxTrig : MonoBehaviour {


void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player") 
		{ 
			// If the collider's gameobject is tagged as Box
			// Plays audio

			Debug.Log ("Audio Triggered");

			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play (); 

			/*Gems = GameObject.Find ("Gemstone");
			Gems.GetComponent <MeshRenderer> ().enabled = false;*/
		}
			
	}

}