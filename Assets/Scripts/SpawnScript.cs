using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	
	public GameObject obstacle;
	public GameObject powerup;
	public GameObject platform;

	float timeElapsed = .0f;
	float spawnCycle = Constants.TIME_SPAWNER_CYCLE;
	bool spawnPowerup = true;
	float[] posHorizontalValues;

	void Start() {
		float width = platform.transform.localScale.x;
		float offset = (width / 3);
		posHorizontalValues = new float[3];
		posHorizontalValues[0] = -offset;
		posHorizontalValues[1] = 0;
		posHorizontalValues[2] = offset;
	}

	float genX() {
		return posHorizontalValues[Random.Range(0, posHorizontalValues.Length)];
	}

	void Update () {
		timeElapsed += Time.deltaTime;
		if (timeElapsed > spawnCycle) {
			GameObject temp = (GameObject)Instantiate(spawnPowerup ? powerup : obstacle);
			Vector3 pos = temp.transform.position;
			temp.transform.position = new Vector3(genX(), pos.y, pos.z);
			timeElapsed -= spawnCycle;
			spawnPowerup = !spawnPowerup;
		}
	}

}