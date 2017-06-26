using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public Rigidbody rb;
    public bool moveRight;
    public bool moveLeft;
    Vector3 v1, v2, v3;
    public float speed;
    
    
   
    // Use this for initialization
    void Start () {

       
       
        moveLeft = false;
        moveRight = false;
        
    }
	

    void FixedUpdate()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed);

        if (moveLeft == true) { MoveLeft(); }
        else if(moveRight==true) { MoveRight();  }
        else if( moveRight == true && moveLeft == true ) return;
    }



    public void MoveLeft()
    {
        transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);
       
        
        
        
       
    }



    public void MoveRight()
    {
        transform.Rotate(new Vector3(0, -10, 0) * Time.deltaTime);
       


    }


}
