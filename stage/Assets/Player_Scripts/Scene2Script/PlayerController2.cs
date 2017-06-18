using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

    Rigidbody rb;

    public float speed;
    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 5);
    }
	

	// Update is called once per frame
	void FixedUpdate () {

        transform.Translate(InputManagerScript.MainJoystick().x * speed, 0, 0);
    }
}
