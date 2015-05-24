using UnityEngine;
using System.Collections;

public class HurtRobit : MonoBehaviour {
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col)
	{
		Debug.Log ("BOOM");
	}

}
