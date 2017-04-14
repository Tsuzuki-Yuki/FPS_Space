using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	Camera fpcCamera;
	bool snipeSwitch;
	// Use this for initialization
	void Start () {
		fpcCamera = GetComponent<Camera> ();
		snipeSwitch = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1)) {
			if (!snipeSwitch) {
				fpcCamera.fieldOfView = 20;
				snipeSwitch = true;
			} else {
				fpcCamera.fieldOfView = 60;
				snipeSwitch = false;
			}
		}
	}
}
