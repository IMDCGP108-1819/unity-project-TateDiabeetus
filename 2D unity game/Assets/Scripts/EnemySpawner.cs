using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    //code to make objects spawn around the player but outside the camera area
	public GameObject enemyPrefab;


	     float spawnDistance = 12f;

	float enemyRate = 5;
	float nextEnemy = 1;

	// Update is called once per frame
	void Update ()
    {
	nextEnemy -= Time.deltaTime;

        //increases spawn rate over time
		    if(nextEnemy <= 0)
        {
			nextEnemy = enemyRate;
			enemyRate *= 0.9f;
			if(enemyRate < 2)
				enemyRate = 2;

			Vector3 offset = Random.onUnitSphere;
			offset.z = 0;
			offset = offset.normalized * spawnDistance;


			 Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
		}
	}
}
