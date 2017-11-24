using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour {
	public Text scoreText;
	static float score = 0;
	new Rigidbody2D  rigidbody;
	public float speed = 5.0f;
	public float jumpPower = 5.0f;
	public float mapSpeed = 3.0f;
	public Animator anim;

	bool isJumping;
	bool isMoved; 
	float LimitPos;
	float LimitPos2;

	// Use this for initialization
	void OnCollisionEnter2D(Collision2D coll)
	{

		if (coll.gameObject.tag == "Ground")
		isJumping = false;

		if (coll.gameObject.tag == "Obstacle") {
			Debug.Log ("쿵");
			SceneManager.LoadScene ("GameOver");	
		}
			
		
	}
		

	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {

		LimitPos = -13.32533f;
		LimitPos2 = 11.28857f;


		if (LimitPos > transform.position.x) {
			//transform.position = new Vector2 (LimitPos, transform.position.y);			
			SceneManager.LoadScene("GameOver");
		}

		if (LimitPos2 < transform.position.x)
			transform.position = new Vector2(LimitPos2, transform.position.y);
		
		if (Input.GetKeyDown (KeyCode.Space) && isJumping == false) {
			rigidbody.AddForce (Vector2.up * jumpPower, ForceMode2D.Impulse);
			anim.Play ("Stop");
			isJumping = true;
			isMoved = true;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
			anim.Play ("Walk");
			isMoved = true;
		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector2.left * speed * Time.deltaTime);
			anim.Play ("Walk");
			isMoved = true;
		} 
		else {
			anim.Play ("Stop");
			isMoved = false;
		}

		if(!isMoved)
			transform.Translate (Vector2.left * speed * Time.deltaTime);

		score++;
		scoreText.text = "Score : " + score.ToString();
		
	}
		
}


