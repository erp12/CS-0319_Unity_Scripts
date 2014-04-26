using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float forwardForce = 20f;
	public float turnSpeed = 5f;

	public AudioClip shout1;
	public AudioClip shout2;
	AudioClip currentShout;

	// Use this for initialization
	void Start () {
		currentShout = shout1;
	}
	
	// Update is called once per frame
	void Update () {
		//rigidbody.AddRelativeForce (new Vector3 (0f, 0f, forwardForce));

		if (Input.GetKey ("a")) {
			rigidbody.AddTorque (new Vector3 (0f, turnSpeed * -1, 0f)); 
			//transform.Rotate( new Vector3 (0f, turnSpeed*-1, 0f));
		} else if (Input.GetKey ("d")) {
			rigidbody.AddTorque (new Vector3 (0f, turnSpeed, 0f)); 
			//transform.Rotate( new Vector3 (0f, turnSpeed, 0f));
		} else {
			rigidbody.angularVelocity = rigidbody.angularVelocity * .9f;
		}
		if (Input.GetKey ("s")) {
			rigidbody.AddRelativeForce (new Vector3 (forwardForce * 0.9f, 0f, 0f)); 
			//transform.Rotate( new Vector3 (0f, turnSpeed, 0f));
		} else if (Input.GetKey ("w")) {
			rigidbody.AddRelativeForce (new Vector3 (-forwardForce, 0f, 0f)); 
			//transform.Rotate( new Vector3 (0f, turnSpeed, 0f));
		} else {
			rigidbody.velocity = rigidbody.velocity * .999f;
		}

		if (Input.GetKeyDown ("space")) {
			audio.PlayOneShot(currentShout, 1f);
			if (currentShout.Equals(shout1)){
				currentShout = shout2;
			} else {
				currentShout = shout1;
			}
		}

	}

	void OnTriggerEnter(Collider other) {
		rigidbody.velocity = rigidbody.velocity * .25f;
	}
	
}
