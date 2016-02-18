using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class healthModified : MonoBehaviour {

	public Text livesTargetText; 
	

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			statsManager.health++;
			Debug.Log(statsManager.health);
			livesTargetText.text = statsManager.health.ToString();
		}
	}
}
