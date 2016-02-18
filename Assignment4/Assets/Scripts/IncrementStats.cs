using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IncrementStats : MonoBehaviour {

	public Text playerHealthText;
	public Text playerLivesText;
	public Text playerCharismaText;
	public Text playerScoreText;

	void Start () {

	}
	

	void Update () {
		playerHealthText.text = PlayerManager.playerHealth.ToString();
		playerLivesText.text = PlayerManager.playerLives.ToString();
		playerCharismaText.text = PlayerManager.playerCharisma.ToString();
		playerScoreText.text = PlayerManager.playerScore.ToString();

		if(Input.GetKeyDown(KeyCode.H)){
			PlayerManager.playerHealth++;
		}
		if(Input.GetKeyDown(KeyCode.L)){
			PlayerManager.playerLives++;
		}
		if(Input.GetKeyDown(KeyCode.C)){
			PlayerManager.playerCharisma++;
		}
		if(Input.GetKeyDown(KeyCode.S)){
			PlayerManager.playerScore++;
		}
	}
}
