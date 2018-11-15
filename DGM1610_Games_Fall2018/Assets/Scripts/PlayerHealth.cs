using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int MaxHealth = 100;
    public int CurrentHealth;
    public string HealthText;


    // Use this for initialization
    void Start() {
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
        for (int CurrentHealth = 100; CurrentHealth >= 1; CurrentHealth--);


    }

    void Update() {
        if (CurrentHealth < 0)
            CurrentHealth = 0;
        print("You are Dead" + HealthText);
    }

        public int MaxHealth(int PointsToSubtract) {
        MaxHealth += PointsToSubtract;
    }
    public static void AddPoints(int PointsToAdd)
    {
        CurrentHealth += PointsToAdd;
    }


}



