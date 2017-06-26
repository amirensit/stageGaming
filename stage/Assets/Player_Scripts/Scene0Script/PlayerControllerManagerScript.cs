using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerManagerScript : MonoBehaviour {


    public PlayerController playerController;

    Vector3  v1= new Vector3(0, 0, 2);







    public void MoveLeft()
    {
        playerController.moveRight = false;
        playerController.moveLeft = true;
    }



    public void MoveRight()
    {
        playerController.moveLeft = false;
        playerController.moveRight = true;
    }

    public void initialize()
    {
        playerController.moveLeft = false;
        playerController.moveRight = false;
        //playerController.rb.velocity = playerController.transform.forward;
        
    }


}
