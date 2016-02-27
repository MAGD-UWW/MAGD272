using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class c_deathManager: MonoBehaviour {

	public GameObject inspectButton;
	public GameObject continueButton;

	public GameObject bloodOverlay;

	public float waitTime;
	public float waitTime2;

	void Start () {

		inspectButton.SetActive(false);
		continueButton.SetActive(false);
		bloodOverlay.SetActive(false);
		StartCoroutine(playerDies());
		StartCoroutine(bloodSplatter());
	}


	void Update () {

	}

	IEnumerator playerDies() {
		yield return new WaitForSeconds(waitTime);
		SceneManager.LoadScene("start_scene2");
	}

	IEnumerator bloodSplatter() {
		yield return new WaitForSeconds(waitTime2);
		bloodOverlay.SetActive(true);
	}
}
