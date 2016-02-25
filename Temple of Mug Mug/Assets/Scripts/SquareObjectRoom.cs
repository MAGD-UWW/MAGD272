using UnityEngine;
using System.Collections;

public class SquareObjectRoom : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {
	
		if(textManager.isMessageDone == true) {
			StatManager.isSquareAcquired = true;
		}
	}
}
