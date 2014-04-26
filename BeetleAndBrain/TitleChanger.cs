using UnityEngine;
using System.Collections;

public class TitleChanger : MonoBehaviour {
	public Texture menu1;
	public Texture menu2;
	public Texture menu3;
	public Texture menu4;
	public Texture menu5;
	public Texture menu6;
	public Texture menu7;
	public Texture menu8;
	public Texture menu9;
	public Texture menu10;
	int currentMenu;

	// Use this for initialization
	void Start () {
		
		currentMenu = (int)Random.Range(0f, 10f)+1;

		switch (currentMenu)
		{
		case 1:
			renderer.material.mainTexture = menu1;
			break;
		case 2:
			renderer.material.mainTexture = menu2;
			break;
		case 3:
			renderer.material.mainTexture = menu3;
			break;
		case 4:
			renderer.material.mainTexture = menu4;
			break;
		case 5:
			renderer.material.mainTexture = menu5;
			break;
		case 6:
			renderer.material.mainTexture = menu6;
			break;
		case 7:
			renderer.material.mainTexture = menu7;
			break;
		case 8:
			renderer.material.mainTexture = menu8;
			break;
		case 9:
			renderer.material.mainTexture = menu9;;
			break;
		case 10:
			renderer.material.mainTexture = menu10;
			break;
		default:
			renderer.material.mainTexture = menu1;
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
