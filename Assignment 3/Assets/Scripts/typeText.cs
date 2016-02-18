using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class typeText : MonoBehaviour {

	public string myText = "Hello, what is your name, Stranger?";
	public float interLetterTime;
	public Text targetTypeText;
	public AudioSource textSound;

	void Start () {
		StartCoroutine(addText(myText));
	}

	void Update () {
	
	}

	IEnumerator addText(string text) {
		int textLength = text.Length;
		for(int i = 0; i < textLength + 1; i++) {
			targetTypeText.text = text.Substring(0, i);
			textSound.Play();
			yield return new WaitForSeconds(interLetterTime);
			textSound.Stop();
		}
	}
}
