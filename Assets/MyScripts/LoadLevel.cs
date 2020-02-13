using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//script created entirely by me
public class LoadLevel : MonoBehaviour 
{

	//serialize field makes it visable in the inspector
	[SerializeField] private string loadLevel;



	// When this game object intersects a collider with 'is trigger' checked, 
	// store a reference to that collider in a variable named 'other'..
	IEnumerator OnTriggerStay(Collider other) 
	{
		// ..and if the game object we intersect has the tag 'Player' assigned to it..
		if (other.CompareTag("Player"))
		{


			// wait 2 seconds and then load next scene
			yield return new WaitForSeconds (2);
			Debug.Log ("scene loading");
			SceneManager.LoadScene (loadLevel);


		}
	}
}



