using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public float destroyRate;
	float cooldown = 0;

	void Update()
	{
		if (cooldown < destroyRate)
			cooldown += Time.deltaTime;
		else {
			Destroy(gameObject);
		}
	}
}
