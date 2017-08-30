using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UFOController : MonoBehaviour {

	GameObject bullet;
	public int value;

	// Use this for initialization
	void Start () {
		this.bullet = GameObject.Find ("bullet");
        StartCoroutine("brbr");
	}
	
	// Update is called once per frame
	void Update () {
		GameObject fish = GameObject.Find ("fish3_yellow10");
		if (fish != null) {
			Destroy (fish);
		}

		// 当たり判定
		Vector2 p1 = transform.position; 				// UFOの中心座標
		Vector2 p2 = bullet.transform.position; 	// 弾の中心座標
		Vector2 dir2 = p1 - p2;
		float d = dir2.magnitude;
		float r1 = 1.0f;	// UFOの半径
		float r2 = 0.1f;	// 弾の半径

		if (d < r1 + r2) {
			bullet.transform.position = 
				GameObject.Find("ankou").transform.position;
			UIDirector.AddScore (value);

			StartCoroutine ("blink");
		}
	}
	private IEnumerator blink(){

		for (int i = 0; i < 2; i++) {
			this.GetComponent<SpriteRenderer> ().color *= -1;

			yield return new WaitForSeconds (0.1f);

		}

	}
	private IEnumerator brbr()
	{
        int k = 1;

        while (true)
		{

            transform.Rotate(new Vector3(0,0,12 * k));
			yield return new WaitForSeconds(0.5f);
            transform.Rotate(new Vector3(0, 0, 12 * k * -1));

			k *= -1;
            yield return new WaitForSeconds(0.5f);
		}

	}
}
