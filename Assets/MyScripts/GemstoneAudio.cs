using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemstoneAudio : MonoBehaviour {

	private GameObject Gems;

void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player") 
		{ 
			// If the collider's gameobject is tagged as Box
			// Plays audio

			Debug.Log ("Gemstone Collected");

			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
		
			/*Gems = GameObject.Find ("Gemstone");
			Gems.GetComponent <MeshRenderer> ().enabled = false;*/
		}

	}

}