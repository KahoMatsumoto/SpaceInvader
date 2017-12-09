using System;
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
    public bool center;
    new string name;

	// Use this for initialization
	void Start () {
        name = "fish";
        if (toRight)
        {
            Create(fish, idx, 11);
        }
        else if (center)
        {
            CreateHole(fish, idx);
        }
        else
        { 
			CreateReverse (fish, idx, 11);
		}
	}

    private void CreateHole(GameObject fishPre, int y)
    {
        for (int i = 0; i < 8; i=i+2)
        {
            GameObject go = Instantiate(fishPre) as GameObject;

            if (isShoot) go.name = fishPre.name + i;
            if (isUniqueName) go.name = name + i;
            go.transform.position = new Vector3(-6.25f + i * 1.25f/2, y, 0);
        }
        for (int i = 0; i <= 7; i=i+2)
        {
            GameObject go = Instantiate(fishPre) as GameObject;
            if (isShoot) go.name = fishPre.name + (i + 1);
            if (isUniqueName) go.name = name + (i + 1);
            go.transform.position = new Vector3(6.25f - i * 1.25f/2, y, 0);
        }
    }

    void Create (GameObject fishPre,int y,int n){
		for (int i = 0; i < 11; i++) {
			GameObject go = Instantiate (fishPre) as GameObject;

			if(isShoot) go.name = fishPre.name + i;
			if(isUniqueName) go.name = name + i;
			go.transform.position = new Vector3 (-6.25f + i * 1.25f, y, 0);
		}
	}
	void CreateReverse (GameObject fishPre,int y,int n){
		for (int i = 10; i >= 0; i--) {
			GameObject go = Instantiate (fishPre) as GameObject;
			if(isShoot) go.name = fishPre.name + (-1*i +10);
			if(isUniqueName) go.name = name + (-1*i +10);
			go.transform.position = new Vector3 (-6.25f + i * 1.25f, y, 0);
		}
	}

}

