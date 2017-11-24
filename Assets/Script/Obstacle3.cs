using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle3 : MonoBehaviour {

	public float speed = 10f;
	public GameObject obstacle;
	GameObject obs;

	bool make;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (20f, -2.1f);
		if(make == false)
			obs  = Instantiate (obstacle, transform.position, transform.rotation);

		make = true;
		obs.transform.Translate (Vector2.left * speed * Time.deltaTime);

		if (obs.gameObject.transform.position.x < -13.5) {
			Destroy (obs);
			make = false;
		}
	}
}
