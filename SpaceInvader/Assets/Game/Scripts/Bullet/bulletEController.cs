using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletEController : MonoBehaviour {

	GameObject fish;
	//public float speed;
	int idx;
    public bool isMany;
    public int fIdx;
	Slider slider;
	Toggle toggle;
	int count;
    public bool center;

	// Use this for initialization
	void Start () {
//		transform.position = new Vector2(0, -6);
		//this.tgl = 
		Vector3 pos = GameObject.Find("fish3_yellow" + fIdx).transform.position;
		pos.y++;
		transform.position = pos;
			
		
		this.toggle = GameObject.Find("ToggleMany").GetComponent<Toggle>();
		this.idx = 0;
		this.count = 0;
	}

	// Update is called once per frame
	void Update () {
		// フレームごとに等速で下降させる
		transform.Translate(0,Data.Instance.BESSlevel,0);

		// 画面外に出たらあんこうに戻る
		if (transform.position.y < -5.0f) {
			Shoot();
			if (count < 1 && toggle.isOn) {
				if (fIdx < 9) {
                    if (center && fIdx > 6)
                    {
                    }
                    else
                    {
                        GameObject go = Instantiate(gameObject) as GameObject;
                        go.name = gameObject.name + (fIdx + 1);
                        bulletEController bec = go.GetComponent<bulletEController>();
                        bec.fIdx = this.fIdx + 1;
                        //					bec.isMany = true;
                    }
				}

				count++;
			}
		}
	}

	public void Shoot(){
		if(toggle.isOn) {
            transform.position = 
                GameObject.Find("fish3_yellow" + fIdx).transform.position;
			
            return;
        }
		if (GameObject.Find ("fish3_yellow" + idx%10) != null) {
			this.fish = GameObject.Find ("fish3_yellow" + idx%10);
			//Debug.Log ("fish3_yellow" + idx % 10);
			// 選択したGameObjectの座標を取得
			Vector3 vecFPos = fish.transform.position;
			vecFPos.y = vecFPos.y - 0.5f;
			// オブジェクトに代入
			transform.position = vecFPos;
			if (idx == 10) {
				idx = 0;
			} else {
				idx++;
			}
			return;
		}
	}
}
