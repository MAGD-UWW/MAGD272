using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartSceneManager : MonoBehaviour {

	public GameObject triangleButton;
	public GameObject squareButton;
	public GameObject circleButton;
	public GameObject diamondButton;



	void Start () {

	}
	

	void Update () {
		
		if(StatManager.isTriangleAcquired == true) {
			triangleButton.SetActive(false);
		}
		if(StatManager.isSquareAcquired == true) {
			squareButton.SetActive(false);
		}
		if(StatManager.isDiamondAcquired == true) {
			diamondButton.SetActive(false);
		}
	}
	public void TriangleScene() {
		SceneManager.LoadScene("triangle_scene");
	}

	public void SquareScene() {
		SceneManager.LoadScene("square_scene");
	}

	public void DiamondScene() {
		SceneManager.LoadScene("diamond_scene");
	}

	public void CircleScene() {
		SceneManager.LoadScene("circle_scene");
	}
}
