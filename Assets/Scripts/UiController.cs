using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour {

	public GameObject canvas;
	public Text scorePt;
	public Text bulletNum;
	public Text bulletBoxNum;
	// Use this for initialization
	void Start () {
		//Instantiate (canvas);
	}
	
	// Update is called once per frame
	void Update () {
		scorePt.text = "Pt : " + ScoreController.totalScore;
		bulletNum.text = "Bullet : " + FireController.bullet;
		bulletBoxNum.text = "BulletBox : " + FireController.bulletBox;
	}
}
