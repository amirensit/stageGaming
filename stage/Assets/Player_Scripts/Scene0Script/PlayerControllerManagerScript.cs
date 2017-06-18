using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerManagerScript : MonoBehaviour {


    public GameObject playerController;
    Rigidbody rb;
    Vector3 v1, v2, v3;

	// Use this for initialization
	void Start () {
        rb = playerController.GetComponent<Rigidbody>();
        v1= new Vector3(0, 0, 5);
        v2 = new Vector3(-5, 0, 5);
        v3 = new Vector3(5, 0, 5);
    }
	
	// Update is called once per frame
	void Update () {
		
	}



    public void MoveLeft()
    {
        rb.velocity = v2;
    }



    public void MoveRight()
    {
        rb.velocity = v3;
    }





    public void SetInitialVelocity()
    {
        rb.velocity = v1;

    }


}
