using UnityEngine;
using System.Collections;

public class LevelControl : MonoBehaviour {

	float speed = Constants.SPEED_LEVEL_ENV;

	void Update () {
		float offset = Time.time * speed;                             
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, -offset); 
	}

}
