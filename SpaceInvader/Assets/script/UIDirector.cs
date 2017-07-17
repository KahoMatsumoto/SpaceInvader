using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.UI;

public class UIDirector : MonoBehaviour {

    public Text scoreText; // Text用変数
    private int score = 0; // スコア計算用変数


	// Use this for initialization
	void Start () {
        scoreText.text = "Score:0000"; //初期スコアを代入して画面に表示
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score:" + 
			String.Format ("{0:D4}", Data.Instance.score);
	}
    public static void AddScore(int p) {
		Data.Instance.score += p;
    }
}
