#pragma strict

function OnTriggerEnter (Col : Collider) 


{
    if (Col.CompareTag ("Player"));

    {

	   Debug.Log ("reverb");

	   	var gos : GameObject[];
	   	gos = GameObject.FindGameObjectsWithTag("caveAudio");
	   	for (var go : GameObject in gos)
	   	{
	    	Debug.Log(go);
	   		var rv = Random.value;

	   			
				go.GetComponent.<AudioReverbFilter>().room = rv * 0.9;
				go.GetComponent.<AudioReverbFilter>().decayTime = rv * 16 ;
				//go.GetComponent.<AudioReverbFilter>().dryLevel = -2000;

	 	}
    }
}