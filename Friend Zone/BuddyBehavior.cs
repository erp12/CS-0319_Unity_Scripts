using UnityEngine;
using System.Collections;

public class BuddyBehavior : MonoBehaviour {

	protected Animator animator;

	public float speed = 150f;

	private float timeUntilNextMove;
	private Vector3 currentRandDir;

	public string mode = "DontWander";
	public GameObject playerFollowPoint;
	RaycastHit hitInfo;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();

		timeUntilNextMove = Time.time + Random.value*5;
		RandomDir ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dirToPlayer = playerFollowPoint.transform.position-transform.position;
		dirToPlayer = dirToPlayer.normalized;
		Debug.DrawRay(transform.position + Vector3.up, dirToPlayer * 50f);

		if (Physics.Raycast(transform.position, dirToPlayer, out hitInfo, 50f)) {
			if (hitInfo.collider.tag == playerFollowPoint.tag){
				mode = "follow";
				PlayerBuddyCounter.buddyCount += 1;
			}
		}

		if (mode == "wander") {
			if (Time.time > timeUntilNextMove){
				RandomDir();
				timeUntilNextMove = Time.time + Random.value*5;
			}
			rigidbody.AddRelativeForce(new Vector3(0f, 0f, -speed));
		} else if (mode == "follow") {
			Vector3 dirToFollow = new Vector3(dirToPlayer.x, 0f, dirToPlayer.z);
			rigidbody.AddForce(dirToFollow*speed);
		}
	}

	void RandomDir() {
		transform.eulerAngles = new Vector3(0f, Random.Range(-180f, 180f), 0f);
	}
}
