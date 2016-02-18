using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class typeText : MonoBehaviour {

	public string myText = "Woah, my text is printing out in a cool like manor! Look at it type!";
	public float interLetterTime;
	public Text targetTypeText;

	void Start () {
		StartCoroutine(addText(myText));
	}

	void Update () {
	
	}

	IEnumerator addText(string text) {
		int textLength = text.Length;
		for(int i = 0; i < textLength + 1; i++) {
			targetTypeText.text = text.Substring(0, i);
			yield return new WaitForSeconds(interLetterTime);
		}
	}
}
