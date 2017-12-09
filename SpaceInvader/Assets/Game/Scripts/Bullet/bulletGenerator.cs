using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletGenerator : MonoBehaviour
{

    public GameObject bullet;
    //public bool toRight;
    public bool isMany;
    //	Slider slider;
    public Toggle toggle;
    public bool center = false;



    // Use this for initialization
    void Start()
    {
        
        Create(bullet, 0);
        
    }


    void Create(GameObject bullet, int y)
    {

        GameObject go = Instantiate(bullet) as GameObject;
        go.name = bullet.name + y;
        bulletEController bec = go.GetComponent<bulletEController>();

        bec.fIdx = y;
        if(center) bec.center=true;

    }
}
