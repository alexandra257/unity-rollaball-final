using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyGround : MonoBehaviour {

	IEnumerator OnCollisionEnter(Collision col)
{


	if(col.gameObject.tag == "dirt") // If the collider's gameobject is tagged as Box
	{


		///wait for 0.2 seconds and then make it inactive
		//did not want to instantly deativate or use destroy on the gemstones otherwise there is no chance for the audio to be triggered
		yield return new WaitForSeconds (2);
		col.gameObject.SetActive (false);


		}
	}
}