using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AnkoController3 : MonoBehaviour {
	// githubてすと
	GameObject bE;
	//    GameObject spnMid;


	public int value; // 攻撃されたときの減点
//	int jE;

	// Use this for initialization
	void Start () {
//		this.bE = GameObject.Find ("bulletE");

	}

	// Update is called once per frame
	void Update () {
		//マウスのx,y座標を取得
		Vector3 vecMouse = Input.mousePosition;
		//ワールド座標に変換じゃ！！
		Vector3 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);
		//オブジェクトに代入じゃ！！
		Vector3 ankoPos = new Vector3(screenPos.x, -4, 0);
		transform.position = ankoPos;


//		JugdeE (bE);


	}


//	void OnCollisionEnter2D(Collision2D coll){
//		if (coll.gameObject.tag=="Enemy") {
//			UIDirector.DecScore(value);
//		}
//		Debug.Log (coll.gameObject.name);
//	}
	void OnTriggerEnter2D(Collider2D t) {
		if (t.gameObject.tag=="Enemy") {
			UIDirector.DecScore(value);
		}
//		Debug.Log (t.gameObject.name);
	}

//	void JugdeE(GameObject b) {
//		Vector2 p1 = transform.position; 				// ankoの中心座標
//		Vector2 p2 = b.transform.position; 	// bの中心座標
//		Vector2 dir = p1 - p2;
//		float d = dir.magnitude;
//		float r1 = 0.25f;	// bの半径
//		float r2 = 0.7f;	// ankoの半径
//
//		if (d < r1 + r2 && jE>0)
//		{
//			// 攻撃されたら減点
//			UIDirector.DecScore(value);
//			this.jE = -1;
//			//SceneManager.LoadScene("GameOver");
//		}
//		if (d > r1 + r2) {
//			this.jE = 1;
//		}
//		//Debug.Log ();
//
//	}	


}
