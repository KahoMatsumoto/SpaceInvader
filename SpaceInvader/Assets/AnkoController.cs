using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnkoController : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//マウスのx,y座標を取得
		Vector3 vecMouse = Input.mousePosition;
		//ワールド座標に変換じゃ！！
		Vector3 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);
		//オブジェクトに代入じゃ！！
		Vector3 ankoPos = new Vector3(screenPos.x,-4,0);
		transform.position = ankoPos;
	}
}
