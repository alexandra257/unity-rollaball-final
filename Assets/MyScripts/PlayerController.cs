
//THIS SCRIPT WAS TAKEN FROM UNITY'S ROLL A BALL TUTORIAL SERIES
//I have made a few adjustments which will be stated in the comments


using UnityEngine;
// Include the namespace required to use Unity UI
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour {
	
	// Create public variables for player speed, and for the Text UI game objects
	public float speed;
	public Text countText;
	public Text count2Text;
	public Text winText;
	public Text gameOverText;


	// Create private references to the rigidbody component on the player, and the count of pick up objects picked up so far
	private Rigidbody rb;
	private int count;
	private int count2;

	// At the start of the game..
	void Start ()
	{
		// Assign the Rigidbody component to our private rb variable
		rb = GetComponent<Rigidbody>();

		// Set the count to zero 
		count = 0;
		count2 = 0;

		// Run the SetCountText function to update the UI (see below)
		SetCountText ();

		SetPlatformText ();
		// Set the text property of our Win Text UI to an empty string, making the 'You Win' (game over message) blank
		winText.text = "";


	}

	// Each physics step..
	void FixedUpdate ()
	{
		// Set some local float variables equal to the value of our Horizontal and Vertical Inputs
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// Create a Vector3 variable, and assign X and Z to feature our horizontal and vertical float variables above
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		// Add a physical force to our Player rigidbody using our 'movement' Vector3 above, 
		// multiplying it by 'speed' - our public player speed that appears in the inspector
		rb.AddForce (movement * speed);
	
	}
		

	//When this game object intersects a collider with 'is trigger' checked, 
	//store a reference to that collider in a variable named 'collider'
	IEnumerator OnTriggerEnter(Collider collider) 
	{
		//if the game object we intersect has the tag 'Gemstone' assigned to it
		if (collider.tag == ("Gemstone"))
		{

			//wait for 0.2 seconds and then make it inactive
			//did not want to instantly deativate or use destroy on the gemstones otherwise there is no chance for the audio to be triggered
			yield return new WaitForSeconds (0.2F);
			collider.gameObject.SetActive (false);



			//SCORE COUNTING
			// Add one to the score variable 'count'
			count = count + 1;

			// Run the 'SetCountText()' function (see below)
			SetCountText ();
		}

		if (collider.tag == ("platformClip"))
		{

			//wait for 0.2 seconds and then make it inactive
			//did not want to instantly deativate or use destroy on the gemstones otherwise there is no chance for the audio to be triggered
			yield return new WaitForSeconds (1);



			//SCORE COUNTING
			// Add one to the score variable 'count'
			count2 = count2 + 1;

			// Run the 'SetCountText()' function (see below)
			SetPlatformText ();

		}

	}




	// Create a standalone function that can update the 'countText' UI and check if the required amount to win has been achieved
	void SetCountText()
	{
		// Update the text field of our 'countText' variable
		countText.text = "Gems Collected: " + count.ToString ();

		// Check if our 'count' is equal to or exceeded 25
		if (count == 10) {
			// Set the text value of our 'winText'
			winText.text = "Well done, you collected all the gems!";
		}
	}


	//sets platform text in level 3 for triggers
		void SetPlatformText()
		{
			count2Text.text = "Audio Activated out of 5: " + count2.ToString ();

		if (count2 == 5)
		{
				gameOverText.text = "ALL TRIGGERS ACTIVATED, GAME OVER!";
		}
	}
}