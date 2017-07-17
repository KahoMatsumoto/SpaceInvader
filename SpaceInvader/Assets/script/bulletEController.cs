using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEController : MonoBehaviour {

	GameObject fish;
	public float speed;
	int idx;

	// Use this for initialization
	void Start () {
		this.idx = 1;
		transform.position = new Vector2(-6.25f, 3.5f);
//		this.fish = GameObject.Find ("fish1_red" + idx%10);
//		// 選択したGameObjectの座標を取得
//		Vector3 vecFPos = fish.transform.position;
//		vecFPos.y = vecFPos.y - 0.5f;
//		transform.position = vecFPos;
	}

	// Update is called once per frame
	void Update () {
		// フレームごとに等速で下降させる
		transform.Translate(0,speed,0);

		// 画面外に出たらあんこうに戻る
		if (transform.position.y < -5.0f) {
			Shoot();
		}
	}

	public void Shoot(){
//		// 0-10の整数を生成
//		int r = Random.Range(0,10);
		if (GameObject.Find ("fish3_yellow" + idx%10) != null) {
			this.fish = GameObject.Find ("fish3_yellow" + idx%10);
			Debug.Log ("fish3_yellow" + idx % 10);
			// 選択したGameObjectの座標を取得
			Vector3 vecFPos = fish.transform.position;
			vecFPos.y = vecFPos.y - 0.5f;
			// オブジェクトに代入
			transform.position = vecFPos;
			if (idx == 10) {
				idx = 1;
			} else {
				idx++;
			}
			return;
		}

//		if (GameObject.Find ("fish1_red" + 10) != null) {
//			this.fish = GameObject.Find ("fish1_red" + 10);
//			// 選択したGameObjectの座標を取得
//			Vector3 vecFPos = fish.transform.position;
//			// オブジェクトに代入
//			transform.position = vecFPos;
//			return;
//		}
//		if (GameObject.Find ("fish1_red" + 0) != null) {
//			this.fish = GameObject.Find ("fish1_red" + 0);
//			// 選択したGameObjectの座標を取得
//			Vector3 vecFPos = fish.transform.position;
//			// オブジェクトに代入
//			transform.position = vecFPos;
//			return;
//		}
		//Destroy (gameObject);
	}
}
