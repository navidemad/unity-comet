using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PlayerControls : MonoBehaviour {

	public AudioSource obstacleCollectSound;
	public AudioSource powerupCollectSound;
	public AudioSource jumpSound;
	public AudioSource deathzoneCollectSound;

	void Update () {
		if (Input.GetButton ("Jump")) {
			jumpSound.Play();
		}
	}

	void OnTriggerEnter(Collider other) {
		if (gameObject.tag != Constants.TAG_PLAYER)
			return;
		if (other.gameObject.tag == Constants.TAG_OBSTACLE) {
			obstacleCollectSound.Play();
			SceneManager.LoadScene(Constants.SCENE_LOSE);
		} else if (other.gameObject.tag == Constants.TAG_DEATHZONE) {
			deathzoneCollectSound.Play();
			StartCoroutine(WaitAndSwitchToLoseScene(deathzoneCollectSound.clip.length));
		} else if (other.gameObject.tag == Constants.TAG_POWERUP) {
			powerupCollectSound.Play();
			PlayerData.Instance.Score += Constants.PTS_PER_POWERUP;
			Destroy(other.gameObject);
		}
	}

	IEnumerator WaitAndSwitchToLoseScene(float waitTime) 
	{
		yield return new WaitForSeconds(waitTime);
		SceneManager.LoadScene(Constants.SCENE_LOSE);
	}

}
