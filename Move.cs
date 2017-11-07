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
                        new Vector3(Input.GetAxis("Horizontal"),
                                    Input.GetAxis("Vertical"),
                                    0) * speed * Time.deltaTime);
       // rb.MovePosition(transform.position +
       //                 (Vector3.right * Input.GetAxis("Horizontal") +
      //                  Vector3.up * Input.GetAxis("Vertical")) * speed * Time.deltaTime);
    }
    
}
