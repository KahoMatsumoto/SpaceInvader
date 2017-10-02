using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishGenerator : MonoBehaviour {

	public GameObject fish2_bluePrefab;
	public GameObject fish1_redPrefab;
	public GameObject fish3_yellowPrefab;

	// Use this for initialization
	void Start () {
		Create (fish1_redPrefab, 0);
		Create (fish1_redPrefab, 1);
		Create (fish2_bluePrefab, 2);
		Create (fish2_bluePrefab, 3);
		Create (fish3_yellowPrefab, 4);
	}

	void Create (GameObject fishPre,int y){
		for (int i = 0; i < 11; i++) {
			GameObject go = Instantiate (fishPre) as GameObject;
			go.name = fishPre.name + i;
			go.transform.position = new Vector3 (-6.25f + i * 1.25f, y, 0);
		}
	}

}

