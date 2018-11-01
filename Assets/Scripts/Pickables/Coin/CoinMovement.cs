using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour {

    [Header("MUST BE SET")]
    public Transform coinTransform;

    //[Header("Coin settings")]
    //public float speed = 6f;

	void Start ()
    {
		
	}
	

	void Update ()
    {
        coinTransform.position = new Vector2(coinTransform.position.x - (GameManager.gameSpeed * Time.deltaTime), coinTransform.position.y);
	}
}
