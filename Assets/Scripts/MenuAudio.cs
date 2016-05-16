using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuAudio : SingletonClass<MenuAudio> {

	void OnLevelWasLoaded() {
		if (SceneManager.GetActiveScene().name == Constants.SCENE_GAME) {
			Destroy(this.gameObject);
		}
	}
}
