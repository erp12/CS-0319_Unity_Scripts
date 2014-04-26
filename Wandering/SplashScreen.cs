using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	public Texture2D splash;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button(new Rect(0, 0, Screen.width, Screen.height), splash)){
			Application.LoadLevel(1);
		}
	}
}
