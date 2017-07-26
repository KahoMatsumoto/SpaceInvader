using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletGenerator : MonoBehaviour {

	public GameObject bullet;
	public bool toRight;

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
        StartCoroutine(LoopS(1.0f));
	}

	void Create(GameObject fishPre, int y)
	{

			GameObject go = Instantiate(fishPre) as GameObject;
			go.name = fishPre.name + y;
        bulletEController bec = go.GetComponent<bulletEController>();
        bec.fIdx = y;
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
			// secondで指定した秒数ループします
			yield return new WaitForSeconds(second);
			Create(bullet, i);
            i++;
		}
	}

}
