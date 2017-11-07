using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float speed = 5;
    //Keep a reference to our rigidbody
    private Rigidbody rb;

	void Start () { //called when object is created
        rb = GetComponent<Rigidbody>(); //finds the rigidbody component in this object
	}
	
	void Update () {//called every frame of the game
        rb.MovePosition(transform.position + 
                        new Vector3(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0) +
                        new Vector3(0, speed * Input.GetAxis("Vertical") * Time.deltaTime, 0));

    }
    
}
