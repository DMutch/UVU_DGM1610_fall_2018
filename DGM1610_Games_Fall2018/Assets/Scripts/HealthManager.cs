using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

    public static int Health = 0;

    public Text HealthText;

    //public static int PointPenaltyOnDeath;



    // Use this for initialization
    void Start()
    {
        //ScoreText = GetComponent<Text>();

        Health = 0;

    }

    // Update is called once per frame
    void Update()
    {
         
        if (Health < 0)
            Health = 0;
        HealthText.text = " " + Health;
    }

    public static void AddPoints (int PointsToAdd)
    {
        Health += PointsToAdd;
        
    }

}
