using UnityEngine;
using System.Collections;

public class TriangleObjectRoom : MonoBehaviour {

	void Start () {
	
	}
	

	void Update () {
	
		if(textManager.isMessageDone == true) {
			StatManager.isTriangleAcquired = true;
		}
	}
}
