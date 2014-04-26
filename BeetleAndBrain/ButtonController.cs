using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter() {
		GameObject.Find("Grate").transform.Translate(Vector3.up * 5f);
		transform.Translate(Vector3.down*1f);
	}
}
