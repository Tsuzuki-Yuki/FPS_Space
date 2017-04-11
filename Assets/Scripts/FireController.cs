using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour {

	public GameObject fire;
	public GameObject muzzle;
	public AudioClip fireSound;
	AudioSource audioSource;
	float coolTime;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		coolTime = 0.0f;
	}

	// Update is called once per frame
	void Update () {
		coolTime += Time.deltaTime;

		if (Input.GetMouseButtonDown (0) && coolTime >= 0.5f) {
			Ray ray = new Ray (transform.position + new Vector3(0, 0.1f, 0), transform.forward);
			RaycastHit hit = new RaycastHit ();

			audioSource.PlayOneShot (fireSound);
			GameObject muzzleFire = (GameObject)Instantiate (fire, muzzle.transform.position, muzzle.transform.rotation);
			Destroy (muzzleFire, 0.1f);
			coolTime = 0.0f;

			if (Physics.Raycast (ray, out hit)) {
				GameObject hitFire = (GameObject)Instantiate (fire, hit.point, hit.transform.rotation);
				Destroy (hitFire, 0.1f);
			}
		}

				
	}
}
