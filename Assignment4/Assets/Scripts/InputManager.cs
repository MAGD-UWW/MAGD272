using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InputManager : MonoBehaviour {

	public InputField enterName;
	string yourName;
	public Text outputText;
	string outputMessage = "Welcome to the game ";

	void Start () {


	
	}
	

	void Update () {

		Debug.Log(enterName.text);
		if(Input.GetKeyDown(KeyCode.Escape)) {
			outputText.text = outputMessage + yourName;
		}
	}

	public void EnteringText() {
		yourName = enterName.text;
	}
}
