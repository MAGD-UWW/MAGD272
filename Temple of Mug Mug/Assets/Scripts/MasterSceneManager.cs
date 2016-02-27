using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MasterSceneManager : MonoBehaviour {

	public void triToTri1() {
		SceneManager.LoadScene("t_scene1");
	}

	public void tri1ToTri2() {
		SceneManager.LoadScene("t_scene2");
	}

	public void tri2ToTri3() {
		SceneManager.LoadScene("t_scene3");
	}

	public void tri3ToTri4() {
		SceneManager.LoadScene("t_scene4");
	}

	public void tri4ToTri5() {
		SceneManager.LoadScene("t_scene5");
	}

	public void tri5ToTri6() {
		SceneManager.LoadScene("t_scene6");
	}

	public void tri6ToTriFinal() {
		SceneManager.LoadScene("to_scene");
	}

	public void triFinalToStart() {
		SceneManager.LoadScene("start_scene2");
	}

	public void squToSqu1() {
		SceneManager.LoadScene("s_scene1");
	}

	public void squ1ToSqu2() {
		SceneManager.LoadScene("s_scene2");
	}

	public void squ2ToSqu3() {
		SceneManager.LoadScene("s_scene3");
	}

	public void squ3ToSqu4() {
		SceneManager.LoadScene("s_scene4");
	}

	public void squ4ToSquFinal() {
		SceneManager.LoadScene("so_scene");
	}

	public void squFinalToStart() {
		SceneManager.LoadScene("start_scene2");
	}

	public void squDeathScene() {
		SceneManager.LoadScene("s_death");
	}

	public void diaToDia1() {
		SceneManager.LoadScene("d_scene1");
	}

	public void dia1ToDia2() {
		SceneManager.LoadScene("d_scene2");
	}

	public void dia2ToDia3() {
		SceneManager.LoadScene("d_scene3");
	}

	public void dia3ToDia4() {
		SceneManager.LoadScene("d_scene4");
	}

	public void dia4ToDiaFinal() {
		SceneManager.LoadScene("do_scene");
	}

	public void diaDeathScene() {
		SceneManager.LoadScene("d_death");
	}
}
