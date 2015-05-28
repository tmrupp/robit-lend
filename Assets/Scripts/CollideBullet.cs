using UnityEngine;
using System.Collections;

public class CollideBullet : MonoBehaviour {
	
	void OnTriggerEnter2D (Collider2D col)
	{
		Debug.Log ("BOOM");
	}
}
