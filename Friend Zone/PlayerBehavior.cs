using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {

	protected Animator animator;

	public float forwardForce = 10f;
	public float turnSpeed = 1f;
	float Orientation = 0f;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis ("Horizontal");

		float boost = 1f;
		if (Input.GetKey(KeyCode.LeftShift)) {
			boost = 1.5f;
		}

		rigidbody.AddRelativeForce(Vector3.forward*forwardForce*v*boost);
		rigidbody.AddTorque(Vector3.up*h*turnSpeed);

		if(Mathf.Abs(h) < 1){
			rigidbody.angularVelocity = Vector3.zero;
		}

		if(animator)
		{
			animator.SetFloat("Speed", v);
		}	
	}
}
