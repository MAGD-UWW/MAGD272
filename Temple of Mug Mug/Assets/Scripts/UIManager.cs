using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIManager : MonoBehaviour {

	public GameObject options;

	void Start() {


		options = GameObject.Find("InterfaceUI");
		options.SetActive(false);
	}
	void Update() {

		if(Input.GetKeyDown(KeyCode.Escape)) {
			options.SetActive(true);
		}
		if(Input.GetKeyUp(KeyCode.Escape)){
			options.SetActive(false);
		}
		//Write a script to turn off the UI that's been turned on
	}
	public void ReturnToStart() {
		SceneManager.LoadScene("start_scene");
	}
	public void QuitGame() {
		Application.Quit();
	}
}
