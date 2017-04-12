using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour {

	[SerializeField] private GameObject fire;
	[SerializeField] private GameObject muzzle;
	[SerializeField] private AudioClip fireSound;
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
			Vector3 cameraCenter = new Vector3(Screen.width/2, Screen.height/2, 0);
			Ray ray = Camera.main.ScreenPointToRay(cameraCenter);
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
