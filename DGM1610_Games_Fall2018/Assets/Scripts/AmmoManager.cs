using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour {

    public static int Ammo = 0;

    public Text AmmoText;



    // Use this for initialization
    void Start()
    {
        //ScoreText = GetComponent<Text>();

        Ammo = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Ammo < 0)
            Ammo = 0;
        AmmoText.text = " " + Ammo;
    }

    public static void AddPoints(int PointsToAdd)
    {
        Ammo += PointsToAdd;
    }

}
