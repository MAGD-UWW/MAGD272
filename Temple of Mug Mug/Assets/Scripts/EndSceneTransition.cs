using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndSceneTransition : MonoBehaviour {

	public Image backgroundStart;
	public Image backgroundEnd;

	public AudioSource stoneDoor;
	public AudioSource jungleSound;

	public GameObject endCanvas;

	public static bool endSceneStart = false;

	void Start () {
		
	}
	
	IEnumerator textRead(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		endSceneStart = true;
	}

	void Update () {
		if(textManager.isMessageDone == true && backgroundEnd.rectTransform.localPosition.y < 2) {
			StartCoroutine(textRead(3));
			if(endSceneStart == true) {
				backgroundStart.rectTransform.position += Vector3.up * 0.5f;
				backgroundEnd.rectTransform.position += Vector3.up * 0.5f;

					if(!stoneDoor.isPlaying) {
						stoneDoor.Play();
					}
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
