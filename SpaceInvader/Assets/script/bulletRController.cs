using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class bulletRController : MonoBehaviour {

	GameObject fish;
    public int count = 0;

	// Use this for initialization
	void Start () {
        for(int i = 0; i < 3; i++)
        {
            Thread.Sleep(1000);
        }
        count++;
	}

	// Update is called once per frame
	void Update () {
        if (count == 0) return;
		// フレームごとに等速で下降させる
		transform.Translate(0,0.025f,0);

		// 画面外に出たらあんこうに戻る
		if (transform.position.y < -5.0f) {
			Shoot();
		}
	}

	public void Shoot(){
		// 0-10の整数を生成
		int r = Random.Range(0,10);
		for (int i = 0; i < 10; i++) {
			// プレハブの１つを選択
			if (GameObject.Find ("fish1_red" + r%10) != null) {
				this.fish = GameObject.Find ("fish1_red" + r%10);
				// 選択したGameObjectの座標を取得
				Vector3 vecFPos = fish.transform.position;
				vecFPos.y = vecFPos.y - 0.5f;
				// オブジェクトに代入
				transform.position = vecFPos;
				return;
			}

		}

		if (GameObject.Find ("fish1_red" + 10) != null) {
			this.fish = GameObject.Find ("fish1_red" + 10);
			// 選択したGameObjectの座標を取得
			Vector3 vecFPos = fish.transform.position;
			// オブジェクトに代入
			transform.position = vecFPos;
			return;
		}
		if (GameObject.Find ("fish1_red" + 0) != null) {
			this.fish = GameObject.Find ("fish1_red" + 0);
			// 選択したGameObjectの座標を取得
			Vector3 vecFPos = fish.transform.position;
			// オブジェクトに代入
			transform.position = vecFPos;
			return;
		}
		Destroy (gameObject);
	}
}
