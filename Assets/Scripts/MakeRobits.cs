using UnityEngine;
using System.Collections;

public class MakeRobits : MonoBehaviour {

	private GameObject badrobit;
	public int spawnRate = 2; //Seconds between spawns
	private float cooldown = 0.0f;

	void Start () 
	{
		SpawnEnemy ();
	}

	void Update()
	{
		if (cooldown < spawnRate)
			cooldown += Time.deltaTime;
		else {
			SpawnEnemy ();
			cooldown = 0;
		}
	}

	void SpawnEnemy()
	{
		badrobit = Instantiate (Resources.Load("badrobit")) as GameObject;
		badrobit.transform.position = transform.position;

		GameObject hurtBox = Instantiate (Resources.Load("BadRobitHurtBox")) as GameObject;
		hurtBox.transform.parent = badrobit.transform;
		hurtBox.transform.position = badrobit.transform.position;

	}
}