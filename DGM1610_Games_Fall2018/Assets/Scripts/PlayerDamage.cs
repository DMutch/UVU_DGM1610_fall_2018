using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour {
    public static int Health;

    public Text HealthText;
   // public int CurrentHealth;



    // Use this for initialization
    //void Start()
   
       

    // Update is called once per frame
    void Update()
    {
        if (Health < 0)
            Health = 0;
        
    }

    public static void SubtractPoints(int PointsToSubtract)
    {
        Health -= PointsToSubtract;
    }

}


