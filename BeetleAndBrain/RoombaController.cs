using UnityEngine;
using System.Collections;

public class RoombaController : MonoBehaviour {
	Vector3 targetVector;
	public float distance = 30;
	Vector3 corner1;
	Vector3 corner2;
	Vector3 corner3;
	Vector3 corner4;
	public float speed = 0.1f;

	// Use this for initialization
	void Start () {
		corner1 = transform.position;
		corner2 = new Vector3(corner1.x+distance, corner1.y, corner1.z);
		corner3 = new Vector3(corner1.x+distance, corner1.y, corner1.z+distance);
		corner4 = new Vector3(corner1.x, corner1.y, corner1.z+distance);
		targetVector = corner2;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, targetVector, speed);
		if (transform.position == corner1){
			targetVector = corner2;
		} else if (transform.position == corner2){
			targetVector = corner3;
		} else if (transform.position == corner3){
			targetVector = corner4;
		} else if (transform.position == corner4){
			targetVector = corner1;
		}
	}
}
