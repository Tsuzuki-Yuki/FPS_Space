using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour {

	public GameObject fire;
	public GameObject muzzle;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = new Ray (transform.position + new Vector3(0, 0.1f, 0), transform.forward);
			RaycastHit hit = new RaycastHit ();
			GameObject muzzleFire = (GameObject)Instantiate (fire, muzzle.transform.position, muzzle.transform.rotation);
			Destroy (muzzleFire, 0.1f);

			if (Physics.Raycast (ray, out hit)) {
				GameObject hitFire = (GameObject)Instantiate (fire, hit.point, hit.transform.rotation);
				Destroy (hitFire, 0.1f);
			}
		}

				
	}
}
