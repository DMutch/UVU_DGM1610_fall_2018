using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Manager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Rigidbody2D Player;

	//Particles
	public GameObject DeathParticle;
	publice GameObject RespawnParticle;

	//Respawn Delay
	public float RespawnDelay;


	//Point Penalty on Death
	public int PointPenaltyOnDeath;

	//Store Gravity Value
	private float GravityStore;

	// Use this for initialization
	void Start () {
		player = FindObjectofType<Rigidbody2D> ();
		
	}
	

	}
	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Generate Death Particle
		Instantiate (DeathParticle, player.transform.position, player.transform.rotation);
		//Hide Player
		player.enabled = false; 
		player.GetComponent<Renderer> ().enabled = false;
		//Gravity Reset
		GravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
		player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		player.GetComponent<Rigidbody2D>()velocity = Vector2.zero;
		//Point Penalty
		ScoreManager.AddPoints(-pointPenaltyOnDeath);
	}
	}
}
