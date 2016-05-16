using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {
	
	public float objectSpeed = Constants.SPEED_LEVEL_ITEM;

	void Update () {
		transform.Translate(0, 0, objectSpeed);
	}

}