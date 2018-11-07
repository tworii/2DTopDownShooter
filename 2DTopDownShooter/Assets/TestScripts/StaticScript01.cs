using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticScript01 : MonoBehaviour {
    public static int myNumber = 3;
    public int internalInt;
	// Use this for initialization
	void Start () {
        internalInt = myNumber;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("space"))
            {
            myNumber = 4;
            internalInt = myNumber;
        }

    }
}
