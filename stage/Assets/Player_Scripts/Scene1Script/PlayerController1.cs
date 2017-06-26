using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {


   
    public float  speed;
    float r;
    Vector3 v;
	

    void FixedUpdate()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed);
        r = Input.acceleration.x * Time.deltaTime * speed;
        v = new Vector3(0, r, 0);
        transform.Rotate(v * Time.deltaTime);
       

    }




	
}
