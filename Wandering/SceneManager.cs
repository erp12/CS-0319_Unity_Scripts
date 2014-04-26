using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public int indexOfNextScene;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeScene(){
		Application.LoadLevel(indexOfNextScene);
	}


}
