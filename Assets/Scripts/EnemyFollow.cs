using UnityEngine;
using System.Collections;

public class EnemyFollow : MonoBehaviour {

	public float speed = .5f;
	private GameObject player;


	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 dir = player.transform.position - transform.position;
		transform.position += dir.normalized * speed * Time.deltaTime;
	}
}
