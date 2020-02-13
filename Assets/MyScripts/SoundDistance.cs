using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* https://www.youtube.com/watch?v=vfsRDF9K8jU
 * I got this code from the tutorial above
 * I changed this code to fit my game by adding a second audio source so I could make the sounds more interesting in the forest areas by using more than one sample.
 * It also took a lot of trial and error to figure out the best values to set in the inspector to get this script working how I wanted.
 * 
 */



public class SoundDistance : MonoBehaviour {

	public Transform target;
	public float range;
	public float midRange;
	public float dx;

	private  Transform _tranform;
	private Vector3 offset;

	public AudioSource Audio;
	public AudioSource Audio2;

	public float volume;

	// Use this for initialization
	void Start () {

		_tranform = GetComponent<Transform>();
		dx = 0.0f;

		Audio.volume = 0f;
		Audio2.volume = 0f;

	}
	
	// Update is called once per frame
	void Update () {


		if (target) {	
			//transform.position is current position
			offset = target.position - _tranform.position;
			dx = offset.sqrMagnitude;
		}

			//if the dx is less than range value x range value, log Range 1
			if (dx < range * range) {
				//float r1 = range * range;
				Debug.Log ("Range 1");
				//E.G.If the range is set to 5 in the inspector, Range 1 will trigger at 25 Dx

			}
		
			//if the dx is less than midRange value x midRange value, log Range 2
			if (dx < midRange * midRange) 
		{

			//E.G. If the range is set to 2 in the inspector, Range 2 will trigger at 4 Dx

				float mr2 = midRange * midRange;

				Debug.Log ("Range 2");

				volume = 1 - (dx / mr2);

				Debug.Log("Mr: " + mr2 + ", dx: " + dx + ", vol: " + volume + ", " + (dx / mr2));

				Audio.volume = volume;
				Audio2.volume = volume;



			}
		}
	}