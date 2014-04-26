using UnityEngine;
using System.Collections;

public class BeetleObstacleController : MonoBehaviour {
	int dir = 1;
	Vector3 startingLoc;
	Vector3 endingLoc;
	public float distance = 5f;
	public float speed = 0.1f;


	void Start () {
		startingLoc = transform.position;
		endingLoc = new Vector3 (startingLoc.x + distance, startingLoc.y, startingLoc.z);
	}
	
	void Update () {
		if (!animation.IsPlaying("Walk")) {
			animation.Play ("Walk");
		}

		transform.Translate(Vector3.right*(speed/2)*dir);

		if (transform.position.x < startingLoc.x | transform.position.x > endingLoc.x) {
			dir *= -1;
		}

	}
}
