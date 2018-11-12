using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

	void Start ()
    {
		
	}
	

	void Update ()
    {
        transform.position = new Vector3(transform.position.x - (GameManager.gameSpeed * Time.smoothDeltaTime), transform.position.y, transform.position.z);
	}

    private void OnBecameInvisible()
    {
        transform.SetAsFirstSibling();
        Transform otherBackground = transform.parent.GetChild(1);
        SpriteRenderer otherBackgroundRender = otherBackground.GetComponent<SpriteRenderer>();
        transform.position = new Vector3(otherBackground.transform.position.x + otherBackgroundRender.bounds.size.x, transform.position.y, transform.position.z);
    }
}
