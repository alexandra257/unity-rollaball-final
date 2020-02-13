using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional : MonoBehaviour 
{
	public int score;
	public bool checkpoint;

	//we can use this to reference the Functions script using otherScript
	public Functions otherScript;


	void Update()
	{
		
		if (score == 50) 
		{
			if (checkpoint) 
			{
				//looking for a component in functions, call Death
				//otherScript.GetComponent<Functions>().Death;
				Debug.Log("SCORE IS 50!");


			}
		}

		else if (score == 40 && !checkpoint) 
		{
			Debug.Log("SCORE IS 40!");
		}

		else
		{
				Debug.Log ("SCORE IS 0!");
		}
	}

		void OnTriggerEnter(Collider other)
		{
			if(other.CompareTag("Player"))
			{
				Debug.Log("SCORE IS 0!");
			}
		}
	}
