using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour {

	[SerializeField] private Text Timer;
	[SerializeField] private Text scorePt;
	[SerializeField] private Text bulletNum;
	[SerializeField] private Text bulletBoxNum;
	float startTime;
	float limitTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		startTime += Time.deltaTime;
		limitTime = 90.0f - startTime;
		Timer.text = "タイマー : " + limitTime.ToString("N1") + "s";
		scorePt.text = "Pt : " + ScoreController.totalScore;
		bulletNum.text = "Bullet : " + FireController.bullet + "/30";
		bulletBoxNum.text = "BulletBox : " + FireController.bulletBox;
	}
}
