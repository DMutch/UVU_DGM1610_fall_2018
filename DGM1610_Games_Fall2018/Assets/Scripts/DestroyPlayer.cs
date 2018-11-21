using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour{


        public LevelManager LevelManager;
   // public HealthDamage HealthDamage;


    // Use this for initialization
    void Start()
        {
            LevelManager = FindObjectOfType<LevelManager>();
   
           // HealthDamage = FindObjectOfType<HealthDamage>();
    }

void OnTriggerEnter2D(Collider2D other)
        {
            if (other.name == "NewPC")
            {
                LevelManager.RespawnPlayer();
            
        }
            
             


    }
}

