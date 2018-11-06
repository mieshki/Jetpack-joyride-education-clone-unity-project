using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    [Header("MUST BE SET")]
    public List<GameObject> allCoinsPatterns;

    [Header("Coins spawner settings")]
    public float startSpawningFor = 1f;
    public float timeBetweenSpawn = 5f;

    private Transform[] allSpawnPoints;
    

    private float currentTime;

    void Start ()
    {
        currentTime = startSpawningFor;
    }

	void Update ()
    {
        if (currentTime <= 0)
        {
            //Debug.Log("spawn");
            SpawnRandomCoinsPattern();
            currentTime = timeBetweenSpawn;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    void SpawnRandomCoinsPattern()
    {
        int randomPattern = Random.Range(0, allCoinsPatterns.Count);
        float randomHeight = Random.Range(-2, 2);
        Vector3 pos = new Vector3(0, randomHeight, 0);
        Instantiate(allCoinsPatterns[randomPattern], pos, Quaternion.identity);
    }

}
