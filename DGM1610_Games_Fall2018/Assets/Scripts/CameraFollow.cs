using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public CharacterMove NewPC;

	public bool isFollowing;

	//Camera position offset
	public float xOffset;
	public float yOffset;

	

	// Use this for initialization
	void Start () {
		NewPC = FindObjectOfType<CharacterMove>();

		isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(isFollowing){
			transform.position = new Vector3(NewPC.transform.position.x + xOffset, NewPC.transform.position.y + yOffset, transform.position.z);
		}
	}
}
