using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    
    /*
     For our offset value we will take the current transform position
     and subtract the transform position of the player to find the 
     difference between the two.
         */
    private Vector3 offset;

    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;		
	}
	
	/*LateUpdate is called every frame but it is guaranteed to run after all items
     * have been processed in update.
     */
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
