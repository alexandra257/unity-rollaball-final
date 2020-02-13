using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Functions : MonoBehaviour 
{

	public int health;
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void Death()
	{
		Debug.Log ("I AM HERE!");

	}

	void GodMode()
	{
		Death ();
	}
}
