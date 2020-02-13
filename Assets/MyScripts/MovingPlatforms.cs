using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour {


	public Transform movingPlatform;
	public Transform position1;
	public Transform position2;
	public Vector3 newPosition;

	//control the state machine
	public string currentState;

	//the variable that determines how long it takes to make the 
	//platform move from one place to another
	public float smooth;

	//tells our script when it needs to reset and start heading to a new position
	public float resetTime;


	void Start () {
		//when the script is run for the first time it will call change target and set its new position
		//so we know where to move the platform to
		ChangeTarget();
	}

	//Lerp is to move from one position to another over time

	void FixedUpdate () {
		//taking the moving platforms position, take the current position, target new position and move it there over time
		//can use the smooth variable to make it go faster or slower
		movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPosition, smooth * Time.deltaTime);
	}

	//need two states - moving to position 1 and 2
	void ChangeTarget() {
		
		if(currentState == "Moving To Position 1")
		{
			currentState = "Moving To Position 2";
			newPosition = position2.position;
		}
		else if (currentState == "Moving To Position 2")
		{
			currentState = "Moving To Position 1";
			newPosition = position1.position;
		}
		else if(currentState == "")
		{
			currentState = "Moving To Position 2";
			newPosition = position2.position;
		}
		//will happen after ChangeTarget has executed through its states
		Invoke("ChangeTarget", resetTime);
			
		}
	}
