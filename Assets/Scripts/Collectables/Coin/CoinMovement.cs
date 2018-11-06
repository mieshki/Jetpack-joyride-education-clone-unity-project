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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border") Destroy(this.gameObject);
    }

}
