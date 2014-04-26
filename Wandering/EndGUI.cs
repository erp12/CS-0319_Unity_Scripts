using UnityEngine;
using System.Collections;

public class EndGUI : MonoBehaviour {

	public string credits = "3D Art\t|\tMai Templeton\n" +
		"3D Art\t|\tIan Katzman\n" +
		"2D Art\t|\tJasper Alt\n" +
		"Audio\t|\tLarry Pope\n" +
			"Programming\t|\tEddie Pantridge";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		GUI.Box (new Rect (0, 0, Screen.width, Screen.height), "Credits: \n\n" + credits);
		}
}
