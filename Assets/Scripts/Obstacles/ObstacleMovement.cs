using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {
    [Header("MUST BE SET")]
    public Transform obstacleTransform;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        obstacleTransform.position = new Vector2(obstacleTransform.position.x - (GameManager.gameSpeed * Time.smoothDeltaTime), obstacleTransform.position.y);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border") Destroy(this.gameObject);
    }
}
