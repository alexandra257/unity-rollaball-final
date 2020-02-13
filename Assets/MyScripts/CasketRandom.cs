using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CasketRandom : MonoBehaviour {

	public AudioClip[] clips;
	public AudioMixerGroup output;

	public float minPitch = 0.4f;
	public float maxPitch = 0.6f;

	void OnTriggerEnter (Collider other)
	{
		//if the Player collides with the box trigger, play one of the random clips 
	if (other.gameObject.tag == "Player") 
			
		{
			PlaySound ();
		}
	}

	void PlaySound()
	{
		//randomize
		int randomClip = Random.Range (0, clips.Length);

		//create an AudioSource
		AudioSource source = gameObject.AddComponent<AudioSource> ();

		//load clip into the AudioSource
		source.clip = clips [randomClip];

		//set the output for the AudioSource
		source.outputAudioMixerGroup = output;

		//set random pitch
		source.pitch = Random.Range (minPitch, maxPitch);

		//play the clip
		source.Play ();

		//destroy the AudioSource when done playing the clip
		Destroy(source, clips[randomClip].length);

	}
}
