using UnityEngine;
using System.Collections;

public class DoNotDestroy : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad(gameObject); //Does not destroy the object this script is attached to

	}

}
