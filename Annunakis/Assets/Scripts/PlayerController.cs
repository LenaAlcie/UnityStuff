using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour{

	public float speed;
	private Rigidbody2D body2d;
    private int counter;
    public Text countText;
    public Text winText;

	void Start(){

		body2d = GetComponent<Rigidbody2D> ();

        counter = 0;
        winText.text = " ";

        SetCountText();

    }

	void FixedUpdate(){

		float moveHorizontal = Input.GetAxis ("Horizontal");

		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		body2d.AddForce (movement * speed);
	}

	/*We use trigger event so the spaceship doesn't collide with the gold
	but activate a trigger without colliding.*/

	void OnTriggerEnter2D(Collider2D other){

		if(other.gameObject.CompareTag("PickUp")){

			other.gameObject.SetActive(false);
            counter++;
            SetCountText();

        }
	}

    void SetCountText() {

        countText.text = "Count : " + counter.ToString();

        if (counter >= 10) {
            winText.text = "YOU WIN";
        }

    }

}

