using UnityEngine;
using System.Collections;

public class GuidePointLegacy : MonoBehaviour {

	public GameObject guideAnimal;
	GuideAnimalLegacy animal;
	
	// Use this for initialization
	void Start () {
		animal=guideAnimal.GetComponent<GuideAnimalLegacy>();
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
