using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class start_scenes : MonoBehaviour {

	public float pauseType;
	public Text targetTextElement;

	public string message;

	void Start () {
		StartCoroutine(TypeText());
		Debug.Log(message);
	
	}

	IEnumerator TypeText() {
		for(int i = 0; i < message.Length + 1; i++){
			targetTextElement.text = message.Substring(0, i);
			yield return new WaitForSeconds(pauseType);
		}
	}


	void Update () {
	
	}

	public void TriangleScene() {
		SceneManager.LoadScene("triangle_scene");
	}
}
