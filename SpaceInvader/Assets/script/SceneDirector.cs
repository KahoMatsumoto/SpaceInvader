using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDirector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.R)){
			SceneManager.LoadScene ("Right");
		}
		if(Input.GetKey(KeyCode.L)){
			SceneManager.LoadScene ("Left");
		}
	}
}
