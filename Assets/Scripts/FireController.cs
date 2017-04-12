﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour {

	[SerializeField] private GameObject fire;
	[SerializeField] private GameObject muzzle;
	[SerializeField] private AudioClip fireSound;
	[SerializeField] private AudioClip reloadSound;
	AudioSource audioSource;
	float coolTime;
	float reloadTime;
	int bullet;
	int bulletUpLimit;
	int bulletBox;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		coolTime = 0.0f;
		bulletUpLimit = 30;
		bullet = bulletUpLimit;
		bulletBox = 150;
	}

	// Update is called once per frame
	void Update () {
		coolTime += Time.deltaTime;
		reloadTime += Time.deltaTime;


		//発砲
		if (Time.time < reloadSound.length) { //ゲーム再生からreloadSound.timeだけ発砲できなかったので
			if (Input.GetMouseButtonDown (0) && coolTime >= 0.5f && bullet > 0) {
				Firing ();
			}
		} else {
			if (Input.GetMouseButtonDown (0) && coolTime >= 0.5f && bullet > 0 && reloadTime > reloadSound.length) {
				Firing ();
			}
		}

		//リロード機能
		if (Input.GetKey ("r") && bullet < bulletUpLimit && bulletBox > 0) {
			int reload = bulletUpLimit - bullet;
			audioSource.PlayOneShot (reloadSound);
			reloadTime = 0.0f;


			if (bulletBox > reload) {
				bullet += reload;
				bulletBox -= reload;
			} else {
				bullet += bulletBox;
				bulletBox = 0;
			}
		}
	}

	//発砲機能
	void Firing(){
		Vector3 cameraCenter = new Vector3 (Screen.width / 2, Screen.height / 2, 0);
		Ray ray = Camera.main.ScreenPointToRay (cameraCenter);
		RaycastHit hit = new RaycastHit ();

		audioSource.PlayOneShot (fireSound);
		GameObject muzzleFire = (GameObject)Instantiate (fire, muzzle.transform.position, muzzle.transform.rotation);
		Destroy (muzzleFire, 0.1f);
		coolTime = 0.0f;
		--bullet;

		if (Physics.Raycast (ray, out hit)) {
			GameObject hitFire = (GameObject)Instantiate (fire, hit.point, hit.transform.rotation);
			Destroy (hitFire, 0.1f);
		}
	}
}
