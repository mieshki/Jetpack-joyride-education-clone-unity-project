using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            
            //Destroy(collision.gameObject);
            ReloadScene();
        }
        else if (collision.tag == "Coin")
        {
            CollectCoin(collision.gameObject);
        }
        //else Debug.Log(collision.tag);
    }

    void CollectCoin(GameObject coinObj)
    {
        Debug.Log("points++");
        GameManager.coins++;
        Destroy(coinObj);
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
