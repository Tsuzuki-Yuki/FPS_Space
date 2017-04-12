using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetHitController : MonoBehaviour {

	private GameObject target;
	int targetLife;
	Animator anim;
	// Use this for initialization
	void Start () {
		targetLife = 5;
		target = transform.parent.gameObject;
		anim = target.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Bullet") {
			targetLife--;
			if (targetLife == 0) {
				anim.SetBool("broken", true);
			}
		}
	}
}
