using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	/*A prefab is a template that contains a blueprint of a game object.
     We can use it in our project. */
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15,30,45) * Time.deltaTime );
        /*smooth and frame rate independent. */
	}
}
