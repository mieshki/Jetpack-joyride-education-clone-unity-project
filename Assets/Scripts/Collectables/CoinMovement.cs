using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour {

    [Header("MUST BE SET")]
    public Transform coinTransform;

	void Start ()
    {
		
	}

	void Update ()
    {
        coinTransform.position = new Vector2(coinTransform.position.x - (GameManager.gameSpeed * Time.smoothDeltaTime), coinTransform.position.y);
	}

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
