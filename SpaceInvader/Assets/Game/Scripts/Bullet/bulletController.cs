﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletController : MonoBehaviour {

	//public Slider slider;
    public GameObject ankou;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// フレームごとに等速で上昇させる
		transform.Translate(0,Data.Instance.BPSSlevel,0);

		// 画面外に出たらあんこうに戻る
		if (transform.position.y > 5.0f) {
			Shoot();
		}
	}

	public void Shoot(){
        //マウスのx,y座標を取得
        //Vector3 vecMouse = Input.mousePosition;
        //ワールド座標に変換じゃ！！
        //Vector3 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);
        //オブジェクトに代入じゃ！！
        //Vector3 ankoPos = new Vector3(screenPos.x,-4,0);
        Vector3 ankoPos =ankou.transform.position;
        transform.position = ankoPos;
	}
}
