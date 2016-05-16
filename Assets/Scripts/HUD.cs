using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class HUD : SingletonClass<HUD> {

    public Text score;
    public Text highScore;

	void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadScene(Constants.SCENE_MENU);
        }
        this.score.text = PlayerData.Instance.Score.ToString();
        this.highScore.text = PlayerData.Instance.HighScore.ToString();
	}

	void OnLevelWasLoaded() {
		if (SceneManager.GetActiveScene().name == Constants.SCENE_MENU || 
			SceneManager.GetActiveScene().name == Constants.SCENE_GAME) {
            PlayerData.Instance.Score = 0;
        }
    }

}
