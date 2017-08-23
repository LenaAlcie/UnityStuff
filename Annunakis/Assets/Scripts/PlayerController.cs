using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour{
	public float speed;

	private Rigidbody2D body2d;

	void Start(){
		body2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		body2d.AddForce (movement * speed);
	}

}