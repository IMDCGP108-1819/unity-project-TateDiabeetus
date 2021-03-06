﻿using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

	public GameObject playerPrefab;

	GameObject playerInstance;

	public int numLives = 5;

	float respawnTimer;

	// Use this for initialization
	void Start () {
		SpawnPlayer();
	}
    //code to make the player respawn when it is destroyed
	void SpawnPlayer() {
		numLives--;
		respawnTimer = 1;
		playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);

	}

	
	// Update is called once per frame
	void Update () {
		if(playerInstance == null && numLives > 0) {
		respawnTimer -= Time.deltaTime;

		if(respawnTimer <= 0)
            {
				SpawnPlayer();
			}
		}
	}

	void OnGUI() {
      if(numLives > 0 || playerInstance!= null) {

      GUI.Label( new Rect(0, 0, 100, 50), "Lives Left: " + numLives);
		}

		else
        {
            //game over message when all lives are gone

			GUI.Label( new Rect( Screen.width/2 - 50 , Screen.height/2 - 25, 100, 50), "Game Over! Press space to retry");

		}
	}
}
