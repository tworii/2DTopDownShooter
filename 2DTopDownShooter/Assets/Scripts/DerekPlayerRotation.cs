﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerekPlayerRotation : MonoBehaviour {

    public float mouseAngle = 0;
    public float rotationSpeed = 5.0f;

    private Vector2 mouseDirection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mouseDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        mouseAngle = Mathf.Atan2(mouseDirection.y, mouseDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, mouseAngle);
    }
}
