using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AnkoController : MonoBehaviour {
	// githubてすと
	GameObject bR, bY, bB;
    GameObject spnMid;

	// Use this for initialization
	void Start () {
		this.bR = GameObject.Find ("bulletR");
		this.bB = GameObject.Find ("bulletB");
		this.bY = GameObject.Find ("bulletY");
        this.spnMid = GameObject.Find("spnMid");
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

        /*
        //マウスのx,y座標を取得
        Vector3 vecMouse = spnMid.transform.position;
		//ワールド座標に変換じゃ！！
		Vector3 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);
		//オブジェクトに代入じゃ！！
		Vector3 ankoPos = new Vector3(screenPos.x,-4,0);
		transform.position = ankoPos;

    */

		Jugde (bR);
		Jugde (bB);
		Jugde (bY);


	}

	void Jugde(GameObject b) {
		Vector2 p1 = transform.position; 				// ankoの中心座標
		Vector2 p2 = b.transform.position; 	// bの中心座標
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.25f;	// bの半径
		float r2 = 0.7f;	// ankoの半径

		if (d < r1 + r2) {
			SceneManager.LoadScene ("GameOver");
            Debug.Log("遷移");
		}
		//Debug.Log ();

	}

}
