using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletGenerator : MonoBehaviour {

	public GameObject bullet;
	//public bool toRight;
	public bool isMany;
	Slider slider;


	// Use this for initialization
	void Start()
	{
		//if (toRight)
		//{
            Create(bullet, 0);
		//}
		//else
		//{
		//	CreateReverse(bullet, 4);
		//}

			
		this.slider = GameObject.Find ("FishSpeedSlider").GetComponent<Slider> ();
		StartCoroutine (LoopS (slider.value));


	}


	void Create(GameObject bullet, int y)
	{

		GameObject go = Instantiate(bullet) as GameObject;
		go.name = bullet.name + y;
        bulletEController bec = go.GetComponent<bulletEController>();
        bec.fIdx = y;
		if (isMany) {
			bec.isMany = true;
		} else {
			bec.isMany = false;
		}
	}
	//void CreateReverse(GameObject fishPre, int y)
	//{
	//	for (int i = 10; i >= 0; i--)
	//	{
	//		GameObject go = Instantiate(fishPre) as GameObject;
	//		go.name = fishPre.name + (-1 * i + 10);
	//		go.transform.position = new Vector3(-6.25f + i * 1.25f, y, 0);
	//	}
	//}
    private IEnumerator LoopS(float second)
	{
        // ループ

		int i = 1;
		while (i<=9)
		{
			if (isMany) {
				// secondで指定した秒数ループします
				yield return new WaitForSeconds(second);
				Create(bullet, i);
				Debug.Log ("Create" + i + "!");
				i++;
			}
		}
        
	}

}
