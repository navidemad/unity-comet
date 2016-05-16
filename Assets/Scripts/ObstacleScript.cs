using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {

	public float objectSpeed = Constants.SPEED_LEVEL_ITEM;

	void Update () {
		transform.Translate(0, objectSpeed, 0);
	}

}