using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

//Player Movement Variables
	public int MoveSpeed; 
	public float JumpHeight = 15;

	//Player Grounded Variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;


	// Use this for initialization
	void Start () {
		print("HelloWorld");
		
	}
	void FixedUpdate () {
		Grounded = Physics2D.OverLapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}
	// Update is called once per frame
	void Update () {

		//This code makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
		}
		
		//This code makes the character move from side to side using the A&D keys
		if(Input.GetKey (keyCode.D)){
			GetComponent<RigidBody2D>().velocity = new Vector2(MoveSpeed, GetComponent<RigidBody2D().velocity.y);

		}
		if(Input.GetKey (KeyCode.A)){
			GetComponent<RigidBody2D>().velocity = new Vector2(MoveSpeed, GetComponent<RigidBody2D>().velocity.y);

		}
	}

	public void Jump(){
		GetComponent<RigidBody2D>().velocity = new Vector2(GetComponent<RigidBody2D>().velocity.x, JumpHeight);
	}
}