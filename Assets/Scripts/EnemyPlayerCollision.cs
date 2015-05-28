using UnityEngine;
using System.Collections;

public class EnemyPlayerCollision : MonoBehaviour {

	private GameObject playerHitBox;
	public int impulse = 5;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag.Equals ("Player")) 
		{
			playerHitBox = col.gameObject;

			Vector3 fromTo = playerHitBox.transform.position - transform.position;
			Rigidbody2D rb = playerHitBox.GetComponentInParent<Rigidbody2D>();
			rb.AddForce(fromTo*impulse,ForceMode2D.Impulse);
		}
	}
}
