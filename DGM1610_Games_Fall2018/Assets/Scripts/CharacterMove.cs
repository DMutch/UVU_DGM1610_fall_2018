﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove: MonoBehaviour {

    //Player Movement Variables
	public int MoveSpeed; 
	public float JumpHeight = 10;
	private bool DoubleJump;

	//Player Grounded Variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	//Non-Stick Player     
	private float moveVelocity;


	// Use this for initialization
	void Start () {
		//print("HelloWorld");
		
	}
	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}
	// Update is called once per frame
	void Update () {

		//This code makes the character jump
		if(Input.GetKeyDown (KeyCode.Space) && Grounded){
			Jump();
		}
		
		//Double jump code
		if(Grounded)
			DoubleJump = false;

		if(Input.GetKeyDown (KeyCode.Space)&& !DoubleJump && !Grounded){
			Jump();
			DoubleJump = true;
		}
		//Non-Stick Player
		moveVelocity = 0f;

		//This code makes the character move from side to side using the A&D keys
		if(Input.GetKey (KeyCode.D)){
			    //GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
					moveVelocity = MoveSpeed;
		}

		if(Input.GetKey (KeyCode.A)){
			    //GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
				moveVelocity = -MoveSpeed;
		}
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

	//Player flip
	if (GetComponent<Rigidbody2D>().velocity.x > 0)
		transform.localScale = new Vector3(4f,4f,1f);

	else if (GetComponent<Rigidbody2D>().velocity.x < 0)
		transform.localScale = new Vector3(-4f,4f,1f);
	}

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}