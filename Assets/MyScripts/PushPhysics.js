#pragma strict

var pushPower = 2.0;


function OnControllerColliderHit (hit : ControllerColliderHit)
{
// looking for rigidbody
	var body : Rigidbody = hit.collider.attachedRigidbody;

	//if we dont hit a rigidbody or kinematic, dont do anything
	if(body == null || body.isKinematic)
	//return to begining
	return;

	//if we hit an object that is below our character, we dont want to be able to push it
	if(hit.moveDirection.y <-0.3)
	return;

	//setting vector 3 to only push along x or z
	var pushDir : Vector3 = Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
	body.velocity = pushDir * pushPower;
}