using UnityEngine;
using System.Collections;

public class BrainInJarController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.parent.position;

		if (Input.GetKey ("a")) {
			rigidbody.AddTorque (Vector3.down);
		} else if (Input.GetKey ("d")) {
			rigidbody.AddTorque (Vector3.up);
		}

		if (Input.GetKey ("s")) {
			rigidbody.AddTorque(Vector3.back);
		} else if (Input.GetKey ("w")) {
			rigidbody.AddTorque(Vector3.forward);
		}
	}
}
