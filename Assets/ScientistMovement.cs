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
    Vector3 spawnPos;

    void Start() {
        movementSpeed = Random.Range(minMovementSpeed, maxMovementSpeed);

        int rand = Random.Range(0, 2);
        spawnPos = scientistTransform.position;

        if (rand == 0)
        {
            goRight = 1;
            spawnPos.x = -10;
        }
        else
        {
            goRight = -1;
            spawnPos.x = 10;
        }

        scientistTransform.position = spawnPos;
    }
	
	void Update ()
    {  
        scientistTransform.position += new Vector3(movementSpeed * goRight * Time.deltaTime, 0, 0);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
