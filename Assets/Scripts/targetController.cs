using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetController : MonoBehaviour {

	[SerializeField] private GameObject target;
	// Use this for initialization
	void Start () {
		GameObject targetObj = (GameObject) Instantiate (target, transform.position, Quaternion.identity);
		targetObj.transform.parent = this.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
