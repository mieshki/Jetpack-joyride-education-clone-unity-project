using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static float gameSpeed = 6f;

    [Header("UI Settings")]
    public Text metersText;
    public Text coinsText;

    private float meters = 0;
    public static int coins = 0;

	void Start ()
    {
		
	}

	void Update ()
    {
        meters += Time.deltaTime * gameSpeed;

        metersText.text = "Meters: " + meters.ToString("0000");
        coinsText.text = "Coins: " + coins.ToString("000");
	}
}
