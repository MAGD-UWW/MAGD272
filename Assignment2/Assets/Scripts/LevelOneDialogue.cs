using UnityEngine;
using UnityEngine.SceneManagement; //Allows scene management library
using UnityEngine.UI; //Allows UI library
using System.Collections;

public class LevelOneDialogue : MonoBehaviour {
	/**
	 * Game objects on the scene to regulate with SetActive
	 * StartScene used for Scene Management 
	**/
	public GameObject creatureText;
	public GameObject bouldarText;
	public GameObject creatureSprite;
	public GameObject talkToCreature;
	public GameObject backToStart;
	public GameObject bouldarRoll;
	public string startScene;

	void Start () {
		/**
		 * Sets the proper UI elements to false at the beginning 
		 * 
		**/
		creatureText.SetActive(false);
		bouldarText.SetActive(false);
		creatureSprite.SetActive(false);
		talkToCreature.SetActive(false);
		backToStart.SetActive(false);
		bouldarRoll.SetActive(false);
	}
	

	void Update () {
		StartCoroutine("WaitForTime"); //Starts the coroutine for the creature to spawn and talk
	}
	public void ToStartScene() {

		SceneManager.LoadScene(startScene, LoadSceneMode.Single); //Used for the back to start button (Scene Transition)
	}
	public void bouldarDialogue() {
		/**
		 * Sets the bouldar dialogue options to true once the user clicks button
		 * 
		**/
		bouldarRoll.SetActive(true); 
		bouldarText.SetActive(true);
		backToStart.SetActive(true);
	}
	IEnumerator WaitForTime() { //Enumerator Function for the beginning of the game, (Creature Spawn)
		yield return new WaitForSeconds(3.0f);
		creatureText.SetActive(true);
		talkToCreature.SetActive(true);
		creatureSprite.SetActive(true);
	}
}
