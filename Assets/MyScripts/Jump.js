#pragma strict

var jumpHeight = 8;

private var isFalling = false;


function Update () 
{
	//if space bar is held down

	if  (Input.GetKeyDown(KeyCode.Space) && isFalling == false)
	{
		//sets velocity on the y axis to jumpHeight - positive numbers jump up, negative down
		GetComponent.<Rigidbody>().velocity.y = jumpHeight;
		isFalling = true;
	}
}

function OnCollisionStay ()

{
	isFalling = false;
}



//https://www.youtube.com/watch?v=PazLGgeFkHI&t=187s