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
        transform.position = new Vector3(transform.position.x - (GameManager.gameSpeed * Time.smoothDeltaTime), transform.position.y, transform.position.z);
	}

    private void OnBecameInvisible()
    {
        transform.SetAsFirstSibling();
        Transform otherBackground = transform.parent.GetChild(1);
        SpriteRenderer otherBackroundRender = otherBackground.GetComponent<SpriteRenderer>();
        //Debug on actual backgound size
        //Debug.Log(otherBackgroundRender.bounds.size.x);
        transform.position = new Vector3(otherBackground.transform.position.x + otherBackroundRender.bounds.size.x, transform.position.y, transform.position.z);
    }

}
