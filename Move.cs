using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float speed = 5;
	void Start () { //called when object is created
	}
	
	void Update () {//called every frame of the game
        transform.position += new Vector3(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
        transform.position += new Vector3(0, speed * Input.GetAxis("Vertical") * Time.deltaTime, 0);
    }
    
}
