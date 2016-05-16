using UnityEngine;
using System.Collections;

public class PlayerData : SingletonClass<PlayerData> {
	
    private int score = 0;
    private int highScore = 0;

	protected PlayerData() {
        highScore = PlayerPrefs.GetInt(Constants.KEY_PREF_HIGHSCORE);
    }

    public int Score {
        get {
            return this.score;
        }
        set {
            score = value;
            if (score > highScore) {
                this.highScore = score;
				PlayerPrefs.SetInt(Constants.KEY_PREF_HIGHSCORE, highScore);
            }
        }
    }

    public int HighScore {
        get {
            return this.highScore;
        }
    }

}
