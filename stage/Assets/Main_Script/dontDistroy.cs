using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDistroy : MonoBehaviour {

	// Use this for initialization
	void Awake () {

        DontDestroyOnLoad(gameObject);

	}
	
	
}
