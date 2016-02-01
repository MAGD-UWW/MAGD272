using UnityEngine;
using UnityEngine.SceneManagement; //Allows usage of SceneManagement library
using System.Collections;

public class SceneTransition : MonoBehaviour {

	public string firstLevel; //String to be assigned in the inspector, SceneManager GameObject
	public string highScoreScene; //String to be assigned in the inspector, SceneManager GameObject

	void Start () {
	
	}
	

	void Update () {
	
	}
	public void levelOneSceneChange() {

		SceneManager.LoadScene(firstLevel, LoadSceneMode.Single); //Changes scene to first level through Start Game button
	}

	public void highScoreSceneChange() {

		SceneManager.LoadScene(highScoreScene, LoadSceneMode.Single); //Changes scene to high score through High Score button
	}
}
