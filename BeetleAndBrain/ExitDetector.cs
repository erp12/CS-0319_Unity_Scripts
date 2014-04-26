using UnityEngine;
using System.Collections;

public class ExitDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter() {
		print ("HIT");
		Application.LoadLevel ("WinScene");
	}
}
