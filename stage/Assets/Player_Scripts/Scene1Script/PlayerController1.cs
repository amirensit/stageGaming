using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {


     Rigidbody rb;
    public int  speed;
    float x;
	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 5);

    }
	

    void FixedUpdate()
    {
        x = Input.acceleration.x * Time.deltaTime * speed;
        
        
        transform.Translate(x, 0, 0);

    }




	
}
