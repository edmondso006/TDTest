using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public float spawnDelay = .01f;
    public GameObject enemy;

    public Transform[] spawnPoints;
    float nextTimeToSpawn = 0f;

		// Update is called once per frame
	void Update () {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnEnemy();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
	}

    void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
