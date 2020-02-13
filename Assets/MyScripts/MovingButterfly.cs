using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingButterfly : MonoBehaviour {

	public Transform movingButterfly;
	public Transform position1;
	public Transform position2;
	public Transform position3;
	public Transform position4;
	public Transform position5;
	public Transform position6;
	public Transform position7;
	public Transform position8;
	public Vector3 newPosition;

	//control the state machine
	public string currentState;

	//the variable that determines how long it takes to make the butterfly move from one place to another
	public float smooth;

	//tells our script when it needs to reset and start heading to a new position
	public float resetTime;
	public enum Positions {POS1, POS2, POS3, POS4, POS5, POS6, POS7, POS8};

	public Positions currentPosition;

	void Start () {
		
		//when the script is run for the first time it will call change target and set its new position
		//so we know where to move the butterfly to
		ChangeTarget();
	}


	void FixedUpdate () {
		
		//taking the moving platforms position, take the current position, target new position and move it there over time
		//can use the smooth variable to make it go faster or slower
		//Lerp is to move from one position to another over time

		movingButterfly.position = Vector3.Lerp (movingButterfly.position, newPosition, smooth * Time.deltaTime);
	}

	//series of conditions that allow the butterfly to move from positions 1-8 via triggers I've set up
	void ChangeTarget() {

		if (currentPosition == Positions.POS1)
		{
			Debug.Log ("Pos1->2");
			currentPosition = Positions.POS2;
			newPosition = position2.position; 
		}

		else if (currentPosition == Positions.POS2) 
		{
			Debug.Log ("Pos2->3");
			currentPosition = Positions.POS3;
			newPosition = position3.position;
		}

		else if (currentPosition == Positions.POS3) 
		{
			Debug.Log ("Pos3->4");
			currentPosition = Positions.POS4;
			newPosition = position4.position;
		}

		else if (currentPosition == Positions.POS4) 
		{
			Debug.Log ("Pos4->5");
			currentPosition = Positions.POS5;
			newPosition = position5.position;
		}

		else if (currentPosition == Positions.POS5) 
		{
			Debug.Log ("Pos5->6");
			currentPosition = Positions.POS6;
			newPosition = position6.position;
		}

		else if (currentPosition == Positions.POS6) 
		{
			Debug.Log ("Pos6->7");
			currentPosition = Positions.POS7;
			newPosition = position7.position;
		}

		else if (currentPosition == Positions.POS7) 
		{
			Debug.Log ("Pos7->8");
			currentPosition = Positions.POS8;
			newPosition = position8.position;
		}

		//loop the statement back to pos1 and starts the sequence again
		else if (currentPosition == Positions.POS8)
		{
			Debug.Log ("Pos1->2");
			currentPosition = Positions.POS1;
			newPosition = position1.position; 
		}

		Invoke("ChangeTarget", resetTime);

	}
}

//https://www.youtube.com/watch?v=AfwmRYQRsbg
