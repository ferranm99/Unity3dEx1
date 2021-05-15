using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Before rendering each frame..
	float speed = 10.0f;
	private Rigidbody rb;
	void Update () 
	{
		// Rotate the game object that this script is attached to by 15 in the X axis,
		// 30 in the Y axis and 45 in the Z axis, multiplied by deltaTime in order to make it per second
		// rather than per frame.
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);

		Vector3 vel = Random.onUnitSphere * speed;
		vel.y = 0.0f;
		transform.Translate(vel * Time.deltaTime);
	}
}	