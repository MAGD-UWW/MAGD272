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
		if(StatManager.isDiamondAcquired == true) {
			Diamond.SetActive(true);
		}
		if(StatManager.isSquareAcquired == true) {
			Square.SetActive(true);
		}
	}
}
