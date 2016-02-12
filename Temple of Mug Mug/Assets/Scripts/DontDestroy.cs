using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DontDestroy : MonoBehaviour {
	/*											   	
	 * Attached to the Background Music Game Object 
	 * 												
	 */	
	void Awake() {
		DontDestroyOnLoad(gameObject); //Will not destroy object when a new scene loads
	}
}
