using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    //Access Modifiers
    //public - anyone can see it
    //(default) private - only this object can see it
    //protected - only this object and child objects can see it
    public float speed = 5;
    private bool moveRight = false;
    private bool moveLeft = false;
    private bool moveUp = false;
    private bool moveDown = false;
	void Start () { //called when object is created
	}
	
	void Update () {//called every frame of the game
        //Vector - a set of points
        //Vector3 - a set of 3 points (x,y,z)
        //Vector3 newPosition = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        Vector3 newPosition = transform.position;
        moveLeft = Input.GetKey(KeyCode.A);
        moveRight = Input.GetKey(KeyCode.D);
        moveUp = Input.GetKey(KeyCode.W);
        moveDown = Input.GetKey(KeyCode.S);

        if (moveRight)
        {
            //newPosition = newPosition + new Vector3(speed * Time.deltaTime, 0, 0);
            // = assignment operator
            // + addition operator
            // += increment operator
            newPosition += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (moveLeft)
        {
            // -= decrement operator
            newPosition -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (moveUp)
        {
            newPosition += new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (moveDown)
        {
            newPosition -= new Vector3(0, speed * Time.deltaTime, 0);
        }

        transform.position = newPosition;
	}
    
}
