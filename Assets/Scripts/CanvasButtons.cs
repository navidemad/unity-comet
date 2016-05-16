using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CanvasButtons : MonoBehaviour {

	public void StartGame() {
		SceneManager.LoadScene(Constants.SCENE_GAME);
	}

	public void MainMenu() {
		SceneManager.LoadScene(Constants.SCENE_MENU);
	}

}
