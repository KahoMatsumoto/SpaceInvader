using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Data  
{
	public readonly static Data Instance = new Data();

	public int score = 0;
	public string name = string.Empty;

    public float BESSlevel = 0.021f;
    public float BPSSlevel = 0.021f;
    public float FSSlevel = 0.021f;
}