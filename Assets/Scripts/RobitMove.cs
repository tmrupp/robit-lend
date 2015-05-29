using UnityEngine;
using System.Collections;

public class RobitMove : MonoBehaviour {
	public float speed = .5f;

	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		Vector3 move = new Vector3 (h, v, 0.0f);
		transform.position = transform.position + move * speed * Time.deltaTime;
	}
}
