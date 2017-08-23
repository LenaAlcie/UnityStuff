using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 How to reference different components. 
 We will create a variable to reference that component in the
 start function. GetComponent<xxx>()
     */
public class PlayerController : MonoBehaviour {

    private Rigidbody rigidbodyComponent;
    public float speed; //editable property in Unity

    private void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }
    //is called before rendering a frame
    /*
	void Update () {
		
	}
	*/

    //called before perfoming physics calculations. 
    void FixedUpdate () {
        /*
         This grabs the input from our player through the keyboard.
         The float variables moveHor/Verti record the input from the 
         horizontal and vertical axis, wich are controlled by the keys on a keyboard.
         Player object -> rigidbody -> Physics 
         Input -> forces to rigidbody = move Player
         */
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //We don't want to move up or down, so we let it 0 float. 

        rigidbodyComponent.AddForce(movement * speed);
        /*Vector 3 holds 3 decimal values in one container used
         for example in adding force or rotation, that needs
         x, y, z axis.
         To add speed: multiply the movement for some value.
         
         */
	}
}
