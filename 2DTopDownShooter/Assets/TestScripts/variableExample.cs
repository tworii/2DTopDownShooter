using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variableExample : MonoBehaviour {

    public int integerExample = 5;
    public float floatExample = 1.234f;
    public GameObject objectExample;


	// Use this for initialization
	void Start () {
        objectExample.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
