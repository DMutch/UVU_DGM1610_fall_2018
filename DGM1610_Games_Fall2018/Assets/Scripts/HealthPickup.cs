using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

    public int PointsToAdd;
    private Healthbar PlayerHealth;

    public void Start()
    {
        PlayerHealth = FindObjectOfType<Healthbar>();
    }

    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.GetComponent<Rigidbody2D>() == null)
            return;

        if (PlayerHealth.CurrentValue < PlayerHealth.MaxHealth)
        {
            PlayerHealth.SetHealth(PlayerHealth.CurrentValue + PointsToAdd);
            //HealthManager.AddPoints(PointsToAdd);

            Destroy(gameObject);
        }
        
        
    }

}
