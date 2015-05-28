using UnityEngine;
using System.Collections;

public class PolanMove : MonoBehaviour {

	public float speed = 3f; 

	void Update () 
	{
		float v = Input.GetAxisRaw ("Vertical");
		float h = Input.GetAxisRaw ("Horizontal");

		Vector3 moveDir = new Vector3 (h, v, 0);
		transform.position = transform.position + moveDir * speed * Time.deltaTime;
	}
}
