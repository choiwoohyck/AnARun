using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_BackGround : MonoBehaviour {
	private new Renderer renderer;
	public float ScrollSpeed = 0.5f;
	float Offset = 0.1f;
	// Update is called once per frame
	void Start () {
		renderer = GetComponent<Renderer> ();
	}

	void Update () {
		Offset = Time.time * ScrollSpeed;
		renderer.material.SetTextureOffset ("_MainTex", new Vector2 (Offset, 0));
	}
}
