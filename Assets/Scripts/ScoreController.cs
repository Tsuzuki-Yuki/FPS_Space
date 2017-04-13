using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {

	[SerializeField] private GameObject headMarker;
	float scoreDistance;
	int score;
	Vector3 headMarkerCenter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		headMarkerCenter = headMarker.GetComponent<Renderer>().bounds.center;
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Bullet") {
			scoreDistance = Vector3.Distance (headMarkerCenter, FireController.hitLocation);
			score = (int)((1 - scoreDistance) * 100);
			print (score);
		}
	}
}
