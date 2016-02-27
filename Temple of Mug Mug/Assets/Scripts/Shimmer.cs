using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Shimmer : MonoBehaviour {

	public Image shimmerEffect;

	private bool isBeggining = true;

	public float shimmerDuration;

	public Color temp;

	void Start() {
		temp = shimmerEffect.color;
		temp.a = 0f;
		shimmerEffect.color = temp;
	}

	void Update() {
		if(isBeggining == true) {
			temp.a += Time.deltaTime/shimmerDuration;
			shimmerEffect.color = temp;
		}
		if(temp.a >= 0.9) {
			isBeggining = false;
			/**
			if(isBeggining == false) {
				temp.a -= Time.deltaTime/shimmerDuration;
			}
			**/
		}
		if(isBeggining == false) {
			temp.a -= Time.deltaTime/shimmerDuration;
			shimmerEffect.color = temp;
			if(temp.a <= 0.2) {
				isBeggining = true;
			}
		}
		Debug.Log(temp.a);
	}
}
