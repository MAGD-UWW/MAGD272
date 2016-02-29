using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KnobManager : MonoBehaviour {

	public Image knobOne;
	public Image knobTwo;
	public Image knobThree;

	public AudioSource rumbleSound;

	public static bool isKnobOneCorrect = false;
	public static bool isKnobTwoCorrect = false;
	public static bool isKnobThreeCorrect = false;

	private int knobOneCount = 0;
	private int knobTwoCount = 0;
	private int knobThreeCount = 0;

	void Start () {

	}
	

	void Update () {
		if(knobOneCount == 1) {
			isKnobOneCorrect = true;
		}
		else {
			isKnobOneCorrect = false;
		}
		/*******************************/
		if(knobTwoCount == 2) {
			isKnobTwoCorrect = true;
		}

		else {
			isKnobTwoCorrect = false;
		}
		/********************************/
		if(knobThreeCount == 3) {
			isKnobThreeCorrect = true;
		}
		else {
			isKnobThreeCorrect = false;
		}
		/********************************/
	}

	public void rotateKnobOne() {
		knobOne.transform.Rotate(new Vector3(0,0,-90));
		knobOneCount++;
		rumbleSound.Play();
		if(knobOneCount == 4) {
			knobOneCount = 0;
		}
	}
	public void rotateKnobTwo() {
		knobTwo.transform.Rotate(new Vector3(0,0,-90));
		knobTwoCount++;
		rumbleSound.Play();
		if(knobTwoCount == 4) {
			knobTwoCount = 0;
		}
	}
	public void rotateKnobThree() {
		knobThree.transform.Rotate(new Vector3(0,0,-90));
		knobThreeCount++;
		rumbleSound.Play();
		if(knobThreeCount == 4) {
			knobThreeCount = 0;
		}
	}
}
