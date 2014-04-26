using UnityEngine;
using System.Collections;

public class CollideSoundManager : MonoBehaviour {

	public AudioClip impactSound;
	public float volume;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter() {
		audio.PlayOneShot(impactSound, volume);
	}
}
