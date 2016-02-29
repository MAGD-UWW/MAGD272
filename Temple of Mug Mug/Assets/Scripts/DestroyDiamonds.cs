using UnityEngine;
using System.Collections;

public class DestroyDiamonds : MonoBehaviour {

	void Start() {
		/**
		if(GameObject.Find("DiamondShine").activeInHierarchy == true) {
			Destroy(GameObject.Find("DiamondShine"));
		}
		if(GameObject.Find("DiamondSoundEffect").activeInHierarchy == true) {
			Destroy(GameObject.Find("DiamondSoundEffect"));
		}
		**/
		if(GameObject.Find("DiamondShine") != null) {
			Destroy(GameObject.Find("DiamondShine"));
		}
		if(GameObject.Find("DiamondSoundEffect") != null) {
			Destroy(GameObject.Find("DiamondSoundEffect"));
		}
	}
}
