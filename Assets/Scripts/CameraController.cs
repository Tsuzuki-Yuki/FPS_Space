using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {

	[SerializeField] private Image snipe;
	Camera fpcCamera;
	bool snipeSwitch;
	// Use this for initialization
	void Start () {
		fpcCamera = GetComponent<Camera> ();
		snipe.gameObject.SetActive (false);
		snipeSwitch = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1)) {
			if (!snipeSwitch) {
				fpcCamera.fieldOfView = 20;
				snipe.gameObject.SetActive(true);
				snipeSwitch = true;
			} else {
				fpcCamera.fieldOfView = 60;
				snipe.gameObject.SetActive (false);
				snipeSwitch = false;
			}
		}
	}
}
