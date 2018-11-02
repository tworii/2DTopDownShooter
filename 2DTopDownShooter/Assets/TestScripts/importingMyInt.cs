using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class importingMyInt : MonoBehaviour {


    public int takenNumber;
	// Use this for initialization
	void Start () {
        takenNumber = StaticScript01.myNumber;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
