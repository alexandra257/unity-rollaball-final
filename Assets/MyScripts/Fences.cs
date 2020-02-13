using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fences : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{


		if(col.gameObject.tag == "Player") // If the collider's gameobject is tagged as Box
		{
			

			// Plays audio
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();

		

		}
	}
}