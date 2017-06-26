using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public Rigidbody rb;
    public bool moveRight;
    public bool moveLeft;
    public float x = 5;
    public float speed;
    
    
   
    
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
        Debug.Log(  transform.rotation.eulerAngles.y   );
    }



    public void MoveLeft()
    {
        transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);


        if (Mathf.Abs(transform.rotation.eulerAngles.y) > 60f) return;


    }



    public void MoveRight()
    {
        transform.Rotate(new Vector3(0, -10, 0) * Time.deltaTime);
        if (Mathf.Abs(transform.rotation.eulerAngles.y) > 60f) return;


    }


}
