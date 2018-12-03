using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour {


    private LevelManager LevelManager;
    private Healthbar PlayerHealth;


    // Use this for initialization
    void Start()
    {
        LevelManager = FindObjectOfType<LevelManager>();
        PlayerHealth = FindObjectOfType<Healthbar>();
    }

void OnTriggerEnter2D(Collider2D other)
        {
            if (other.name == "NewPC")
            {
                PlayerHealth.SetHealth(PlayerHealth.CurrentValue - 10);
                LevelManager.RespawnPlayer();
            }


    }
}

