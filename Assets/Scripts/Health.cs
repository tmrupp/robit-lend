using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public int health;
	void hit ()
	{
		health--;
		if (health <= 0)
			Destroy (gameObject);
	}
}
