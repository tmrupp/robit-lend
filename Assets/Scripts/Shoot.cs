using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public int speed;

	void Update() {
		if (Input.GetButtonDown("Fire1")) {
			Vector3 aim = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			aim.z = 0;

			GameObject clone = Instantiate(Resources.Load("GreyTile"), transform.position, transform.rotation) as GameObject;
			clone.transform.LookAt(aim);
			Quaternion rotation = Quaternion.LookRotation(aim - transform.position, transform.TransformDirection(Vector3.up));
			clone.transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
			clone.GetComponent<Rigidbody2D>().AddForce((aim - transform.position).normalized*speed);
		}
	}
}
