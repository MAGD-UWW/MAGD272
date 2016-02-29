using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndSceneTransition : MonoBehaviour {

	public Image backgroundStart;
	public Image backgroundEnd;

	public AudioSource stoneDoor;
	public AudioSource jungleSound;

	public AudioSource backgroundMusic;

	public GameObject endCanvas;
	public GameObject TextCanvas;

	public static bool endSceneMove = false;

	void Start () {
		StatManager.isSquareAcquired = false;
		StatManager.isDiamondAcquired = false;
		StatManager.isTriangleAcquired = false;
		backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();
		backgroundMusic.Stop();
		StartCoroutine(textRead(20));
	}
	
	IEnumerator textRead(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		endSceneMove = true;
		TextCanvas.SetActive(false);
	}

	void Update () {
		if(endSceneMove == true && backgroundEnd.rectTransform.localPosition.y < 2) {
				backgroundStart.rectTransform.position += Vector3.up * 0.5f;
				backgroundEnd.rectTransform.position += Vector3.up * 0.5f;

					if(!stoneDoor.isPlaying) {
						stoneDoor.Play();
					}
		}
		else if(backgroundEnd.rectTransform.localPosition.y >= 2) {
			stoneDoor.Stop();
			endCanvas.SetActive(true);
			if(!jungleSound.isPlaying) {
				jungleSound.Play();
			}
		}
	}
}
