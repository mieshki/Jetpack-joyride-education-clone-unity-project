﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour {

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            Debug.Log("rip");
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Coin")
        {
            Debug.Log("score++");
            Destroy(collision.gameObject);
        }
        else Debug.Log(collision.tag);
    }
}
