using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textManager : MonoBehaviour {

	public float pauseType;
	public Text targetTextElement;

	public string message;
	public string inspectRoom;
	public string extraText;

	public static bool isMessageDone = false;

	void Start () {
		if(StatManager.isSquareAcquired == false && StatManager.isDiamondAcquired == false && StatManager.isTriangleAcquired == false) {
		StartCoroutine(TypeText());
		}
		else if(StatManager.isSquareAcquired == true || StatManager.isDiamondAcquired == true || StatManager.isTriangleAcquired == true) {
			StartCoroutine(TypeExtra());
		}
		Debug.Log(message);
	
	}

	IEnumerator TypeText() {
		for(int i = 0; i < message.Length + 1; i++){
			targetTextElement.text = message.Substring(0, i);
			yield return new WaitForSeconds(pauseType);
		}
		isMessageDone = true;
	}

	IEnumerator TypeInspect() {
		for(int i = 0; i < inspectRoom.Length + 1; i++){
			targetTextElement.text = inspectRoom.Substring(0, i);
			yield return new WaitForSeconds(pauseType);
		}
	}

	IEnumerator TypeExtra() {
		for(int i = 0; i < extraText.Length + 1; i++){
			targetTextElement.text = extraText.Substring(0, i);
			yield return new WaitForSeconds(pauseType);
		}
	}



	void Update () {
	

	}

	public void InspectRoom() {
		StartCoroutine(TypeInspect());
	}

	public void ExtraTextButton() {
		StartCoroutine(TypeExtra());
	}

		
}
