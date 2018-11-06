using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

    Vector3 start = new Vector3(19f, 0, 0);

	void Start ()
    {
		
	}
	

	void Update ()
    {
        this.transform.position = new Vector3(this.transform.position.x - (GameManager.gameSpeed * Time.smoothDeltaTime), this.transform.position.y, this.transform.position.z);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BackgroundBorder")
        {
            this.transform.position = start;
        }
    }

}
