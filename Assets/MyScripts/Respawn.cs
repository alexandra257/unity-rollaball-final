using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	private GameObject Ground;
	public Transform respawnPos;
	public Transform player;

	void Start ()
	{
		//particleSystem.Stop();
	}


	IEnumerator OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") 
		{
			//particleSystem.Play ();
			//audio.PlayOneShot (Death);
			//Destroy (particleSystem);
			Ground = GameObject.Find ("Ground");
			Ground.GetComponent <MeshRenderer> ().enabled = false;

			yield return new WaitForSeconds (1);
			KillPlayer ();		

		}
	}

	void KillPlayer()
	{	
			player.transform.position = respawnPos.position;
	}

}
