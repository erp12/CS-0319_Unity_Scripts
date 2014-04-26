using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float givenTime;
	float startTime;
	int secondsPassed = 0;
	int secondsLeft;

	void Start() {
		startTime = Time.time;
	}

	void Update() {
		secondsPassed = (int)(Time.time - startTime);
		secondsLeft = (int)givenTime - secondsPassed;

		if (secondsLeft == 0) {
			Application.LoadLevel ("LoseScene");
		}
	}

	void OnGUI() {
		GUI.Box(new Rect(0,0,70,60), secondsLeft.ToString());

		if(GUI.Button(new Rect (10,30,50,20), "Menu")) {
			Application.LoadLevel ("MenuScene");
		}

	}
}
