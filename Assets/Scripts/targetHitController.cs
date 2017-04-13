using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetHitController : MonoBehaviour {

	[SerializeField] private GameObject headMarker;
	private GameObject target;
	int targetLife;
	float scoreDistance;
	int score;
	Animator anim;
	Vector3 headMarkerCenter;

	// Use this for initialization
	void Start () {
		targetLife = 5;
		target = transform.parent.gameObject;
		anim = target.GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		headMarkerCenter = headMarker.GetComponent<Renderer>().bounds.center;
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Bullet") {
			targetLife--;
			scoreDistance = Vector3.Distance (headMarkerCenter, FireController.hitLocation);
			score = (int)((1 - scoreDistance) * 100);
			print (score);

			if (targetLife == 0) {
				anim.SetBool("broken", true);
				Invoke ("rebornTarget", 10.0f);
			}
		}
	}

	void rebornTarget(){
		anim.SetBool ("broken", false);
		targetLife = 5;
	}
}
