using UnityEngine;
using System.Collections;

public class RenderSettingsController : MonoBehaviour {

	public Color fogColor;					//Current color of the fog
	public float initialFogDensity = .02f;	//Starting density of the fog
	public float fogDensityLimit = .5f;		//maximum fog density when player is transitioning scenes.

	public float fogDensity = 0.02f;		//Current fog density. (Starts @ max so player fades in)
	public float fogROC = .01f;				//Fog rate of change.

	// Use this for initialization
	void Start () {
		RenderSettings.fogDensity = initialFogDensity;
	}
	
	// Update is called once per frame
	void Update () {

		//TEMPORARY: if the player is pressing the "Q" key, they begin the transition to a new scene
		if (Input.GetKey (KeyCode.E) && RenderSettings.fogDensity < fogDensityLimit) {
			fogDensity += fogROC;
			RenderSettings.fogDensity = fogDensity;
		} else if (RenderSettings.fogDensity > initialFogDensity) {
			fogDensity -= fogROC;
			RenderSettings.fogDensity = fogDensity;
		}

	}

}
