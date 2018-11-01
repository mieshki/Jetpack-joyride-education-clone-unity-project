using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsManager : MonoBehaviour {

    [Header("Physics settings")]
    public Vector2 gravityVector = new Vector2(0f, -20f);

	void Start ()
    {
        Physics2D.gravity = gravityVector;
	}
	
	void Update ()
    {
		
	}
}
