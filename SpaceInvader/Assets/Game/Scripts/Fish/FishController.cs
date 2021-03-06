﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishController : MonoBehaviour {

	Vector3 stPos;
	short dir;
	float count;
	public bool destroy;
	

	GameObject bullet;
//
//    GameObject UIDirector;
    public int value;

	// Use this for initialization
	void Start () {
		this.stPos = transform.position;
		this.dir = -1;
		this.count = stPos.y;
		StartCoroutine ("trnslt");

		this.bullet = GameObject.Find ("bullet");
	}

	// Update is called once per frame
	void Update () {
		// 当たり判定
		Vector2 p1 = transform.position; 				// 魚の中心座標
		Vector2 p2 = this.bullet.transform.position; 	// 弾の中心座標
		Vector2 dir2 = p1 - p2;
		float d = dir2.magnitude;
		float r1 = 0.3f;	// 魚の半径
		float r2 = 0.1f;	// 弾の半径

		if (d < r1 + r2) {
            //// 衝突した場合は弾をもどす
            ////マウスのx,y座標を取得
            //Vector3 vecMouse = Input.mousePosition;
            ////ワールド座標に変換じゃ！！
            //Vector3 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);
            ////オブジェクトに代入じゃ！！
            //Vector3 ankoPos = new Vector3(screenPos.x,-4,0);
            //bullet.transform.position = ankoPos;

            bullet.transform.position = 
                GameObject.Find("ankou").transform.position;
			UIDirector.AddScore (value);
			if (destroy) {
				Destroy (gameObject);
			} else {
				StartCoroutine ("blink");
			}
		}
	}

	private IEnumerator trnslt(){
		while (true) {
			if (Mathf.Abs (stPos.x - transform.position.x) == 1.75f) {
				turn();
				yield return new WaitForSeconds (Data.Instance.FSSlevel);
//				Debug.Log (slider.value);
			}
			transform.Translate (dir*0.25f, 0, 0);

			yield return new WaitForSeconds (Data.Instance.FSSlevel);
		}
	}

	void turn(){
		this.dir *= -1; // 方向転換
		Vector3 crPos = transform.position;
		crPos.y = --count;
		transform.position = crPos;
//		transform.localScale = new Vector3 (-dir*0.15f, 0.15f, 1);
		Vector3	local = transform.localScale;
		local.x = local.x * -1;
		transform.localScale = local;
	}
	private IEnumerator blink(){

		for (int i = 0; i < 2; i++) {
			this.GetComponent<SpriteRenderer> ().color *= -1;

			yield return new WaitForSeconds (Data.Instance.FSSlevel/2);

		}

	}

}
