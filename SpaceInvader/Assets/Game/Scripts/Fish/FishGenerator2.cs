using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishGenerator2 : MonoBehaviour {

	public GameObject fish;
	public bool isShoot;
	public bool isUniqueName;
	//public string name;
	public bool toRight;
	public int idx;

	// Use this for initialization
	void Start () {
		if (toRight) {
			Create (fish, idx);
		} else {
			CreateReverse (fish, idx);
		}
	}

	void Create (GameObject fishPre,int y){
		for (int i = 0; i < 11; i++) {
			GameObject go = Instantiate (fishPre) as GameObject;

			if(isShoot) go.name = fishPre.name + i;
			if(isUniqueName) go.name = name + i;
			go.transform.position = new Vector3 (-6.25f + i * 1.25f, y, 0);
		}
	}
	void CreateReverse (GameObject fishPre,int y){
		for (int i = 10; i >= 0; i--) {
			GameObject go = Instantiate (fishPre) as GameObject;
			if(isShoot) go.name = fishPre.name + (-1*i +10);
			if(isUniqueName) go.name = name + (-1*i +10);
			go.transform.position = new Vector3 (-6.25f + i * 1.25f, y, 0);
		}
	}

}

