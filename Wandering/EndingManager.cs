using UnityEngine;
using System.Collections;

public class EndingManager : MonoBehaviour {

	public Transform Player;				//Reference to player. Set in Inspector.
	RaycastHit hitInfo;						//Raycast hit info.
	public float distanceToPlayerThreshold = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Direction to player
		Vector3 dirToPlayer = Player.position - (transform.position+Vector3.up);
		dirToPlayer = dirToPlayer.normalized;
		
		//If player is in range of interactable object, particles emit from object
		Debug.DrawRay(transform.position+Vector3.up, dirToPlayer*distanceToPlayerThreshold);
		if (Physics.Raycast (transform.position + Vector3.up, dirToPlayer, out hitInfo, distanceToPlayerThreshold)) {
						if (hitInfo.collider.tag == "Player") {
				Application.LoadLevel(6);
						}
				}
	}
}
