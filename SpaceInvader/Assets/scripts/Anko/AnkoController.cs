using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AnkoController : MonoBehaviour {
	// githubてすと
	GameObject bR, bY, bB;
//    GameObject spnMid;


	public int value; // 攻撃されたときの減点
	int jR,jB,jY;

	// Use this for initialization
	void Start () {
		this.bR = GameObject.Find ("bulletR");
		this.bB = GameObject.Find ("bulletB");
		this.bY = GameObject.Find ("bulletY");
       
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


		JugdeR (bR);
		JugdeB (bB);
		JugdeY (bY);


	}

	void JugdeB(GameObject b) {
		Vector2 p1 = transform.position; 				// ankoの中心座標
		Vector2 p2 = b.transform.position; 	// bの中心座標
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.25f;	// bの半径
		float r2 = 0.7f;	// ankoの半径

		if (d < r1 + r2 && jB>0)
		{
			// 攻撃されたら減点
			UIDirector.DecScore(value);
			this.jB = -1;
			//SceneManager.LoadScene("GameOver");
		}
		if (d > r1 + r2) {
			this.jB = 1;
		}
		//Debug.Log ();

	}	
	void JugdeR(GameObject b) {
		Vector2 p1 = transform.position; 				// ankoの中心座標
		Vector2 p2 = b.transform.position; 	// bの中心座標
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.25f;	// bの半径
		float r2 = 0.7f;	// ankoの半径

		if (d < r1 + r2 && jR>0)
		{
			// 攻撃されたら減点
			UIDirector.DecScore(value);
			this.jR = -1;
			//SceneManager.LoadScene("GameOver");
		}
		if (d > r1 + r2) {
			this.jR = 1;
		}
		//Debug.Log ();

	}	
	void JugdeY(GameObject b) {
		Vector2 p1 = transform.position; 				// ankoの中心座標
		Vector2 p2 = b.transform.position; 	// bの中心座標
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.25f;	// bの半径
		float r2 = 0.7f;	// ankoの半径

		if (d < r1 + r2 && jY>0)
		{
			// 攻撃されたら減点
			UIDirector.DecScore(value);
			this.jY = -1;
			//SceneManager.LoadScene("GameOver");
		}
		if (d > r1 + r2) {
			this.jY = 1;
		}
		//Debug.Log ();

	}

}
