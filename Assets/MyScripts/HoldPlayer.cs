using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldPlayer : MonoBehaviour {

	//when something collides with us, we will become its' parent
	void OnTriggerEnter (Collider col){
		col.transform.parent = gameObject.transform;
	}

	//when something leaves the collider, it doesn't have a parent anymore so remove the relationship
	void OnTriggerExit (Collider col){
		col.transform.parent = null;
	}
}
