using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetHitController : MonoBehaviour {

	int targetLife;
	// Use this for initialization
	void Start () {
		targetLife = 5;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Bullet") {
			targetLife--;
			if (targetLife == 0) {
				print ("5発当たった");
			}
		}
	}
}
