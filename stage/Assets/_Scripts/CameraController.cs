﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset,r;


	// Use this for initialization
	void Start ()
    {

        offset = transform.position - player.transform.position;
	}
	

	// Update is called once per frame
	void LateUpdate ()
    {

        if (Input.GetKeyDown(KeyCode.A))
            r = Vector3.zero;


        else if (Input.GetKeyDown(KeyCode.Q))
            r = offset;

            transform.position = player.transform.position + r;
    }
}
