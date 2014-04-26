using UnityEngine;
using System.Collections;

public class WinScreen : MonoBehaviour {
	public Texture winScreen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button (new Rect (0, 0, Screen.width, Screen.height), winScreen)) {
			Application.LoadLevel ("MenuScene");
		}
	}
}
