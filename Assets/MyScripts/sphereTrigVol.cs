using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sphereTrigVol : MonoBehaviour {

	public AudioSource Audio;
	public float volume;

	void Start () 
	{
		Audio.volume = 0.0f;
	}

	void OnTriggerEnter(Collider collider)
	{
		// If the collider's gameobject is tagged as pushSphere, the audio will play
		if (collider.gameObject.tag == ("pushSphere"))
		{ 
			Debug.Log ("Sphere Detected!");
			Audio = GetComponent<AudioSource> ();

			Debug.Log ("Volume On");
			Audio.volume = 0.5f;

			//makes the pushSphere object a parent of the box trigger so that it can't roll out 
			//(it occasionally was elsewhere on the platform when I revisited)
			collider.transform.parent = gameObject.transform;


		}



	}
}
