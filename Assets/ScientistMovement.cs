using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScientistMovement : MonoBehaviour {

    public Transform scientistTransform;

    public float movementSpeed;
    public float minMovementSpeed = 0.05f;
    public float maxMovementSpeed = 0.2f;

    private Vector2 dir;

    int goRight = 1;

	void Start () {
        movementSpeed = Random.Range(minMovementSpeed, maxMovementSpeed);

        int rand = Random.Range(0, 2);

        if (rand == 0) goRight = 1;
        else goRight = -1;

	}
	
	void Update ()
    {
        
        scientistTransform.position += new Vector3(movementSpeed * goRight * Time.deltaTime, 0, 0);
    }
}
