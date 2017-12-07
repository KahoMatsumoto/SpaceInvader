using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour {

    private Slider slider;
    private float level;
    

	// Use this for initialization
	void Start () {
        slider = GetComponent<Slider>();
        string name = slider.name;
        if (name == "BulletESpeedSlider")
        {
            level = Data.Instance.BESSlevel;
        } else if (name == "BulletPSpeedSlider")
        {
            level = Data.Instance.BPSSlevel;
        } else
        {
            level = Data.Instance.FSSlevel;
        }
        slider.value = level;
	}
	
	// Update is called once per frame
	void Update () {
		if(slider.value != level)
        {
            level = slider.value;
            string name = slider.name;
            if (name == "BulletESpeedSlider")
            {
                Data.Instance.BESSlevel = level; ;
            }
            else if (name == "BulletPSpeedSlider")
            {
                Data.Instance.BPSSlevel = level;
            }
            else
            {
                Data.Instance.FSSlevel = level;
            }
        }
	}
}
