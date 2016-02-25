using UnityEngine;
using System.Collections;

public class FlickeringLights : MonoBehaviour {

	public GameObject gLight;
	public float waitTime;
	public float waitTime2;

	void Start () {
	
		gLight.SetActive(false);
		StartCoroutine(Flicker());
	}
	

	void Update () {
	
	}

	IEnumerator Flicker(){
		gLight.SetActive(true);
		yield return new WaitForSeconds(waitTime);
		gLight.SetActive(false);
		yield return new WaitForSeconds(waitTime);
		gLight.SetActive(true);
		yield return new WaitForSeconds(waitTime);
		gLight.SetActive(false);
		yield return new WaitForSeconds(waitTime);
		gLight.SetActive(true);
		yield return new WaitForSeconds(waitTime);
		gLight.SetActive(false);
		yield return new WaitForSeconds(waitTime);
		gLight.SetActive(true);
		yield return new WaitForSeconds(waitTime);
		gLight.SetActive(false);
		yield return new WaitForSeconds(waitTime);
		gLight.SetActive(true);
		yield return new WaitForSeconds(waitTime);
		gLight.SetActive(false);
		yield return new WaitForSeconds(waitTime);
		gLight.SetActive(true);
		yield return new WaitForSeconds(waitTime);
		gLight.SetActive(false);
		yield return new WaitForSeconds(waitTime2);
		gLight.SetActive(true);
		yield return new WaitForSeconds(waitTime2);
		gLight.SetActive(false);
		yield return new WaitForSeconds(waitTime2);
		gLight.SetActive(true);
		yield return new WaitForSeconds(waitTime2);
		gLight.SetActive(false);
		yield return new WaitForSeconds(waitTime2);
		gLight.SetActive(true);
		yield return new WaitForSeconds(waitTime2);
		gLight.SetActive(false);
		yield return new WaitForSeconds(waitTime2);
		gLight.SetActive(true);
		yield return new WaitForSeconds(waitTime2);
		gLight.SetActive(false);
		yield return new WaitForSeconds(waitTime2);
		gLight.SetActive(true);
		yield return new WaitForSeconds(waitTime2);
		gLight.SetActive(false);
	}
}
