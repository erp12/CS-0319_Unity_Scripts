using UnityEngine;
using System.Collections;

public class GuidePointBehavior : MonoBehaviour {

	public GameObject guideAnimal;
	GuideAnimalBehavior animal;

	// Use this for initialization
	void Start () {
	animal=guideAnimal.GetComponent<GuideAnimalBehavior>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.collider.tag == guideAnimal.tag) {
			animal.nextGuidePoint();
			//guideAnimal.GetComponent("GuideAnimalBehavior");
		}
	}
}
