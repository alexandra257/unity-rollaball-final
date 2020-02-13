#pragma strict

var maxFallDistance = -10;

function Update () 
{
	if (transform.position.y <= maxFallDistance)
	{
	Debug.Log("Test");
	}
}
