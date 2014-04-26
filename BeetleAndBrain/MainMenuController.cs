using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {
	public int buttonsWidth = 200;
	public int buttonHeight = 10;
	public int buttonBuffer = 20;
	bool onMenu = true;
	bool quitVis = false;
	bool controlsVis = false;
	bool splashUp = false;

	public Texture instructionImage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){ 
			if (!onMenu){
				if (splashUp){
					transform.Translate (new Vector3 (0f, -60f, 0f));
				}
				controlsVis = false;
				quitVis= false;
				splashUp = false;
				onMenu = true;
			}
		}
	}

	void OnGUI() {

		if (onMenu) {
			if (GUI.Button (new Rect (Screen.width / 2 - buttonsWidth / 2, Screen.height / 2 - buttonHeight-buttonBuffer+30, buttonsWidth, buttonHeight), "", GUIStyle.none)) {
				splashUp = true;
				onMenu = false;
				StartCoroutine(BeginGame());
			}

			if (GUI.Button (new Rect (Screen.width / 2 - buttonsWidth / 2, Screen.height / 2+30, buttonsWidth, buttonHeight), "", GUIStyle.none)) {
				controlsVis = true;
				onMenu = false;
			}

			if (GUI.Button (new Rect (Screen.width / 2 - buttonsWidth / 2, Screen.height / 2 + buttonHeight+buttonBuffer+30, buttonsWidth, buttonHeight), "", GUIStyle.none)) {
				quitVis = true;
				onMenu = false;
			}
		}

		if (quitVis) {
			GUI.Box (new Rect (0, 0, 200, 50), "Just leave the webpage silly!\n\nESC to go back");
		}
		if (controlsVis) {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), instructionImage);
		}

		if (splashUp) {
			if (GUI.Button (new Rect (Screen.width-(buttonsWidth/3), Screen.height-(buttonHeight/3), buttonsWidth/3, buttonHeight/3), "Continue")) {
				Application.LoadLevel ("Scene1");
			}
		}
	}

	IEnumerator BeginGame(){
		//onMenu = false;

		transform.Translate (new Vector3 (0f, 60f, 0f));
		yield return new WaitForSeconds(0);

		//transform.Translate (new Vector3 (0f, 30f, 0f));
		//yield return new WaitForSeconds (1);

		//transform.Translate (new Vector3 (0f, 30f, 0f));
		//yield return new WaitForSeconds (1);

		//Application.LoadLevel ("Scene1");
	}
}
