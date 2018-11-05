using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    [Header("MUST BE SET")]
    public GameObject coinsSpawnPointsParent;
    public GameObject coinPrefab;

    [Header("Coins spawner settings")]
    public float startSpawningFor = 1f;
    public float timeBetweenSpawn = 1f;
    public float speedOfSpawning = 2f;

    private Transform[] allSpawnPoints;
    private float currentTime;

    void Start ()
    {
        currentTime = startSpawningFor;
        allSpawnPoints = coinsSpawnPointsParent.GetComponentsInChildren<Transform>();
    }

	void Update ()
    {
        if (currentTime <= 0)
        {
            //Debug.Log("spawn");
            SpawnCoin();
            currentTime = timeBetweenSpawn;
        }
        else
        {
            currentTime -= speedOfSpawning * Time.deltaTime;
        }
    }

    void SpawnCoin()
    {
        int randomSpawnPoint = Random.Range(0, allSpawnPoints.Length);

        /*GameObject tempGO = */Instantiate(coinPrefab, allSpawnPoints[randomSpawnPoint]);

    }

}
