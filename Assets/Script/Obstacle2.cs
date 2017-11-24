using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2 : MonoBehaviour {

	public float speed = 15f;
	public GameObject obstacle;
	GameObject obs;
	GameObject obs2;
	float ran_x;
	bool make;
	bool move;
	// Use this for initialization
	void Start () {
		move = true;
	}

	// Update is called once per frame
	void Update () {
		
		ran_x = Random.Range(-10, 5);
		transform.position = new Vector2 (ran_x, 5);
		if (make == false) {
			obs = Instantiate (obstacle, transform.position, transform.rotation);
			ran_x = Random.Range(-13, 1);
		}
		make = true;
		if(move)
		obs.transform.Translate (Vector2.down * speed * Time.deltaTime);


		if (obs.gameObject.transform.position.y < -4.3f) {
			move = false;
			obs.transform.Translate (Vector2.left * speed * Time.deltaTime);
		}
		if (obs.gameObject.transform.position.x < -13.5) {
			Destroy (obs);
			make = false;
			move = true;
		}
	}
}
