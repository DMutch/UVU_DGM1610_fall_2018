﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour {
    public int CurrentHealth;
    public int Damage;




    // Use this for initialization
    //void Start()



    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    { if(collision.gameObject.tag == "Enemy")
        {
            CurrentHealth -= Damage;
        }
        
    }

}


