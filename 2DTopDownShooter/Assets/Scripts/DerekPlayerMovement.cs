using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerekPlayerMovement : MonoBehaviour {

    //GameObject player;
    //SpriteRenderer playerRenderer;
    //Rigidbody2D playerRB2D;

    public int speed;
    
	// Use this for initialization
	void Start () {
        //// Get player
        //player = GameObject.Find("DerekSprite");
        //// Get player's SpriteRenderer component
        //playerRenderer = player.GetComponent<SpriteRenderer>();
        //playerRenderer.color = Color.red;
        //// Get player's RigidBody2D component
        ////playerRB2D = player.GetComponent<Rigidbody2D>();

        speed = 20;
	}
	
	// Update is called once per frame
	void Update () {
        // Move sprite left/right
        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
        // Move sprite up/down
        transform.Translate(0, speed * Input.GetAxis("Vertical") * Time.deltaTime, 0);
	}
}
