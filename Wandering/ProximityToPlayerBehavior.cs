using UnityEngine;
using System.Collections;

public class ProximityToPlayerBehavior : MonoBehaviour {

	public Transform Player;				//Reference to player. Set in Inspector.
	RaycastHit hitInfo;						//Raycast hit info.

	public ParticleSystem particleSystem;	//Reference to particle system. Set in Inspector.

	public float fogDesityTransitionThreshold = .49f;	//How dense the fog should be before player changes scenes.
	public float distanceToPlayerThreshold = 8f;

	public Color fogColor;					//Current color of the fog
	public float initialFogDensity = .02f;	//Starting density of the fog
	public float fogDensityLimit = .5f;		//maximum fog density when player is transitioning scenes.
	
	public float fogDensity = 0.02f;		//Current fog density. (Starts @ max so player fades in)
	public float fogROC = .01f;				//Fog rate of change.
	
	public SceneManager sceneManager;

	public AudioClip worldShiftSound;

	// Use this for initialization
	void Start () {
		Screen.fullScreen = true;

		particleSystem.Stop();

		RenderSettings.fogDensity = initialFogDensity;
		RenderSettings.fogColor = Camera.main.backgroundColor;
	}
	
	// Update is called once per frame
	void Update () {
		//Direction to player
		Vector3 dirToPlayer = Player.position - (transform.position+Vector3.up);
		dirToPlayer = dirToPlayer.normalized;

		//If player is in range of interactable object, particles emit from object
		Debug.DrawRay(transform.position+Vector3.up, dirToPlayer*distanceToPlayerThreshold);
		if (Physics.Raycast (transform.position+Vector3.up, dirToPlayer, out hitInfo, distanceToPlayerThreshold)) {
			if (hitInfo.collider.tag == "Player"){
				particleSystem.Emit(1);

				if (Input.GetKey (KeyCode.E) && RenderSettings.fogDensity < fogDensityLimit) {
					fogDensity += fogROC;
					RenderSettings.fogDensity = fogDensity;

					if(!audio.isPlaying) {
						audio.PlayOneShot(worldShiftSound);
					}

				} else if (RenderSettings.fogDensity > initialFogDensity) {
					fogDensity -= fogROC;
					RenderSettings.fogDensity = fogDensity;
				}

				if(!Input.GetKey(KeyCode.E)){
					audio.Stop();
				}

				//If fog passes the threshold, the player will change scenes.
				if (RenderSettings.fogDensity >= fogDesityTransitionThreshold) {
					sceneManager.ChangeScene();
				}
			}
		}
	}
}