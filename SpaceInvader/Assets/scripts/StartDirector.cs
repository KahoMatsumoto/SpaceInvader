using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartDirector : MonoBehaviour {

    public GameObject anko;
    public GameObject fune;
    private int i = 0;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 p1 = anko.transform.position;                // ankoの中心座標
        Vector2 p2 = fune.transform.position;  // funeの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 2.0f;   // funeの半径
        float r2 = 0.7f;    // ankoの半径

        
        if (d < r1 + r2)
        {
            i++;
            if (i > 100) {
                SceneManager.LoadScene("Stage1");
            }
            
            Debug.Log(i);
        }
    }
}
