using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour {

    [Header("Obstacles")]
    public GameObject obstaclePrefab;
    public float minObstacleLength = 2f;
    public float maxObstacleLength = 5f;
    public float minObstacleRotation = -20f;
    public float maxObstacleRotation = 20f;

    [Header("Coins")]
    public List<GameObject> allCoinsPatterns;
    public float startSpawningFor = 1f;
    public float timeBetweenSpawning = 2f;
    public float currentTime = 0f;

    [Header("Scientists")]
    public GameObject scientistPrefab;

    void Start ()
    {
        currentTime = startSpawningFor;
    }

	void Update ()
    {
        if (currentTime <= 0)
        {
            SpawnScientist();

            float rand = Random.Range(0f, 1f);
            if (rand < 0.9f) // 90% chance to spawn obstacle
            {
                SpawnObstacle();
                currentTime = timeBetweenSpawning - (GameManager.gameSpeed * 0.05f);
            }
            else // 10% chance to spawn coins
            {
                SpawnRandomCoinPattern();
                // to give some time for collecting coins
                currentTime = 2 * (timeBetweenSpawning - (GameManager.gameSpeed * 0.05f)); 
            } 
        }
        else currentTime -= Time.deltaTime;
    }

    void SpawnObstacle()
    {
        int randomNumb = Random.Range(0, 4);
        float obstacleAngle;

        switch (randomNumb)
        {
            case 0: // horizontally
                {
                    obstacleAngle = 0;
                    break;
                }
            case 1: // vertically
                {
                    obstacleAngle = 90;
                    break;
                }
            case 2: // at 45 angle
                {
                    obstacleAngle = 45;
                    break;
                }
            case 3: // at -45 angle
                {
                    obstacleAngle = -45;
                    break;
                }
            default:
                {
                    obstacleAngle = 0;
                    break;
                }
        }

        float randomHeightSpawn = Random.Range(-4, 4);

        Vector3 pos = new Vector3(12, randomHeightSpawn, 0);

        GameObject tempGO = Instantiate(obstaclePrefab, pos, Quaternion.identity);

        float randomObstacleLength = Random.Range(minObstacleLength, maxObstacleLength);
        tempGO.transform.localScale = new Vector2(randomObstacleLength, tempGO.transform.localScale.y);

        tempGO.transform.Rotate(0, 0, obstacleAngle);
    }

    void SpawnRandomCoinPattern()
    {
        int randomPattern = Random.Range(0, allCoinsPatterns.Count);
        float randomHeight = Random.Range(-1, 2);
        Vector3 pos = new Vector3(0, randomHeight, 0);
        Instantiate(allCoinsPatterns[randomPattern], pos, Quaternion.identity);
    }

    void SpawnScientist()
    {
        Instantiate(scientistPrefab);
    }
}
