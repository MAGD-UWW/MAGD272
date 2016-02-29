using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class InventoryUI : MonoBehaviour {

	public GameObject Triangle;
	public GameObject Diamond;
	public GameObject Square;

	void Start () {
		Triangle.SetActive(false);
		Diamond.SetActive(false);
		Square.SetActive(false);
	}
	

	void Update () {
		if(StatManager.isTriangleAcquired == true) {
			Triangle.SetActive(true);
		}
		else if(StatManager.isTriangleAcquired == false) {
			Triangle.SetActive(false);
		}
		if(StatManager.isDiamondAcquired == true) {
			Diamond.SetActive(true);
		}
		else if(StatManager.isDiamondAcquired == false) {
			Diamond.SetActive(false);
		}
		if(StatManager.isSquareAcquired == true) {
			Square.SetActive(true);
		}
		else if(StatManager.isSquareAcquired == false) {
			Square.SetActive(false);
		}
	}
}
