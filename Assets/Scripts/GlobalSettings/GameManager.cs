using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static float gameSpeed = 8f;
    private float defaultGameSpeed = gameSpeed;

    [Header("UI Settings")]
    public Text metersText;
    public Text coinsText;

    private float meters = 0;
    public static int coins = 0;

    public float speedMultiplier = 0.5f;
    public float speedGameEveryXSeconds = 5f;
    public float currentTime;


    private void Awake() // on scene reload
    {
        meters = 0;
        coins = 0;
        gameSpeed = defaultGameSpeed;
    }

    void Start ()
    {
        currentTime = speedGameEveryXSeconds;
	}

	void Update ()
    {
        meters += Time.deltaTime * gameSpeed;

        metersText.text = "Meters: " + meters.ToString("0000");
        coinsText.text = "Coins: " + coins.ToString("000");

        if (currentTime <= 0)
        {
            gameSpeed += speedMultiplier;
            currentTime = speedGameEveryXSeconds;
        } 
        else currentTime -= Time.deltaTime;
	}
}
