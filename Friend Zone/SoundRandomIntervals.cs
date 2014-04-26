using UnityEngine;
using System.Collections;

public class SoundRandomIntervals : MonoBehaviour {

	public AudioClip sound;

	bool isWaiting = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isWaiting) {
			StartCoroutine(WaitRandomAndSound());
		}
	}

	IEnumerator WaitRandomAndSound() {
		isWaiting = true;
		float waitTime = Random.Range (3, 20);
		yield return new WaitForSeconds(waitTime);
		audio.PlayOneShot (sound);
		isWaiting = false;
	}
}
