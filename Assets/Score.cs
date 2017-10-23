using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	//Scoreを表示するテキスト
	private GameObject scoreText;
	//Score計算用変数
	private int score = 0; 

	// Use this for initialization
	void Start () {
		
		//シーン中のScoreオブジェクトを取得
		this.scoreText = GameObject.Find("Score");

		SetScore(); 

	}
		
	
	// Update is called once per frame
	void Update () {
		
	}		

	void OnCollisionEnter(Collision c) {
		
		this.scoreText.GetComponent<Text> ().text = "Score"+score;

		if (c.gameObject.tag == "SmallStarTag") {
			score += 200;
			Debug.Log (score);
		} else if (c.gameObject.tag == "LargeStarTag") {
			score += 150;
			Debug.Log (score);
		} else if (c.gameObject.tag == "SmallCloudTag" || c.gameObject.tag == "LargeCloudTag") {
			score += 100;
			Debug.Log (score);
		} 
		SetScore();
	}
		
	void SetScore(){
		this.scoreText.GetComponent<Text> ().text = "Score"+score;
	}
}
