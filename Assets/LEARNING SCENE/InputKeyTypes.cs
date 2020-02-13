using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyTypes : MonoBehaviour {

	
	// Update is called once per frame
	void Update ()
	{
		//activaets once when the key is pressed all the way down
		if (Input.GetButtonDown ("TB")) 
		{
			Debug.Log ("DO SOMETHING HERE!");
		}

		//will be activated for as long as the button is held down
		if (Input.GetButton ("TT"))
		{
	
			Debug.Log ("DO SOMETHING ELSE!");
		}
	}
}