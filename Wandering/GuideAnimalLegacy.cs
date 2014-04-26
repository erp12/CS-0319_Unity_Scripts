using UnityEngine;
using System.Collections;

public class GuideAnimalLegacy : MonoBehaviour
{

		public Transform Player;				//Reference to player. Set in Inspector.
		RaycastHit hitInfo;						//Raycast hit info.
	
		public float distanceToPlayerThreshold = 20f;
	
		public GameObject[] guideEmpties = new GameObject[3];	//Objects placed in the scene at guide stop points
		int currentStopIndex;
		bool isMoving = false;
		public float moveForce = .03f;							//How much to move the guide animal

		public Animation anims;

		// Use this for initialization
		void Start ()
		{
				currentStopIndex = -1;
		}
	
		// Update is called once per frame
		void Update ()
		{
				//Direction to player
				Vector3 dirToPlayer = Player.position - (transform.position + Vector3.up);
				dirToPlayer = dirToPlayer.normalized;
		
				//If player is in range of interactable object, particles emit from object
				Debug.DrawRay (transform.position + Vector3.up, dirToPlayer * distanceToPlayerThreshold);
				if (Physics.Raycast (transform.position + Vector3.up, dirToPlayer, out hitInfo, distanceToPlayerThreshold)) {
						if (hitInfo.collider.tag == "Player" && !isMoving) {
								currentStopIndex++;
								transform.LookAt (guideEmpties [currentStopIndex].transform.position);
								isMoving = true;
						}
				}
		
				if (isMoving) {
						transform.LookAt (guideEmpties [currentStopIndex].transform.position);
						rigidbody.AddRelativeForce (Vector3.forward * moveForce);
				}

				if (isMoving) {
						anims.Play ("run_");	
				} else {
						anims.Stop();
				}
		}

		public void nextGuidePoint ()
		{	
				isMoving = false;
		}
}
