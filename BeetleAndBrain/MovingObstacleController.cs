using UnityEngine;
using System.Collections;

public class MovingObstacleController : MonoBehaviour {
	int dir = 1;
	Vector3 startingLoc;
	Vector3 endingLoc;
	public float distance = 5f;
	public float speed = 0.1f;

	// Use this for initialization
	void Start () {
		startingLoc = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		endingLoc = new Vector3 (startingLoc.x, startingLoc.y, startingLoc.z+distance);

		if (transform.position.z < startingLoc.z) {
			dir = 1;
		} else if (transform.position.z > endingLoc.z) {
			dir = -1;
		}
		transform.Translate (new Vector3 (0f, 0f, dir * speed));
	}
}
