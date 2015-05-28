using UnityEngine;
using System.Collections;

public class CollideBullet : MonoBehaviour {
	
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag.Equals ("Enemy")) {
			Debug.Log(col.gameObject);
			Destroy (col.gameObject.transform.parent.gameObject);
			Destroy (gameObject);
		}
	}
}