﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

    public int PointsToAdd;

    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.GetComponent<Rigidbody2D>() == null)
            return;

        HealthManager.AddPoints(PointsToAdd);

        Destroy(gameObject);
    }

}
