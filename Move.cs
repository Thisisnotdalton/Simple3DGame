using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    //Access Modifiers
    //public - anyone can see it
    //(default) private - only this object can see it
    //protected - only this object and child objects can see it
    public float speed = 5;
	void Start () { //called when object is created
	}
	
	void Update () {//called every frame of the game
        //Vector - a set of points
        //Vector3 - a set of 3 points (x,y,z)
        //Vector3 newPosition = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        Vector3 newPosition = transform.position;


        newPosition += new Vector3(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
        newPosition += new Vector3(0, speed * Input.GetAxis("Vertical") * Time.deltaTime, 0);

        transform.position = newPosition;
	}
    
}
