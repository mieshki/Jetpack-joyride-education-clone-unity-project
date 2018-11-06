using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {
    [Header("MUST BE SET")]
    public GameObject obstaclesSpawnPointsParent;
    public GameObject obstaclePrefab;


    [Header("Obstacles spawner settings")]
    public float startSpawningFor = 1f;
    public float timeBetweenSpawn = 1f;
    public float minObstacleLength = 2f;
    public float maxObstacleLength = 5f;
    public float minObstacleRotation = -20f;
    public float maxObstacleRotation = 20f;

    private Transform[] allSpawnPoints;
    private float currentTime;

    void Start ()
    {
        currentTime = startSpawningFor;
        allSpawnPoints = obstaclesSpawnPointsParent.GetComponentsInChildren<Transform>();	
	}
	

	void Update ()
    {
        if (currentTime <= 0)
        {
            //Debug.Log("spawn");
            SpawnObstacle();
            currentTime = timeBetweenSpawn;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
	}

    void SpawnObstacle()
    {
        int randomSpawnPoint = Random.Range(0, allSpawnPoints.Length);

        GameObject tempGO = Instantiate(obstaclePrefab, allSpawnPoints[randomSpawnPoint]);

        float randomObstacleLength = Random.Range(minObstacleLength, maxObstacleLength);
        tempGO.transform.localScale = new Vector2(randomObstacleLength, tempGO.transform.localScale.y);

        float randomObstacleRotation = Random.Range(minObstacleRotation, maxObstacleRotation);
        tempGO.transform.Rotate(0, 0, randomObstacleRotation);
    }

}
