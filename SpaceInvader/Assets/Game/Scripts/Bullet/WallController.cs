using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallController : MonoBehaviour
{

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
    void Start()
    {
        StartCoroutine("ChangeFIDX");
    }

    // Update is called once per frame
    void Update()
    {
 
        // フレームごとに等速で下降させる
        transform.Translate(0, Data.Instance.BESSlevel*10, 0);

        // 画面外に出たらあんこうに戻る
        if (transform.position.y < -5.0f)
        {
            Shoot();

        }
        count++;
    }

    public void Shoot()
    {
        
            transform.position =
                GameObject.Find("fish3_yellow" + fIdx).transform.position;
        
    }
    IEnumerator ChangeFIDX()
    {
        yield return new WaitForSeconds(0.5f);
        fIdx = 3;
        transform.position =
                GameObject.Find("fish3_yellow" + fIdx).transform.position;
        yield return new WaitForSeconds(5.0f);
        fIdx = 6;
        yield return new WaitForSeconds(5.0f);
        fIdx = 9;
        yield return new WaitForSeconds(5.0f);
        Destroy(gameObject);
    }
}
