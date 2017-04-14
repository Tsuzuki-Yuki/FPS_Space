using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	[SerializeField] private GameObject headMarker;
	public static int totalScore;
	float scoreDistance;
	int score;
	Vector3 headMarkerCenter;
	// Use this for initialization
	void Start () {
		totalScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		headMarkerCenter = headMarker.GetComponent<Renderer>().bounds.center;
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Bullet" && TargetHitController.targetLife >= 0) {
			scoreDistance = Vector3.Distance (headMarkerCenter, FireController.hitLocation);
			score = (int)((1 - scoreDistance) * 100);
			totalScore += score;
		}
	}
}
