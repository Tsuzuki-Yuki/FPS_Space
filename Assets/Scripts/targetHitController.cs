﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetHitController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other){
		print (other.gameObject.name);
	}
}
