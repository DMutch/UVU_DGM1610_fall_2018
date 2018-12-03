using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

    public Image HealthBar;

    private int MinHealth;

    public int MaxHealth;

    public Text HealthPercent;

    private int CurrentHealth;

    private float CurrentPercent;

    //Bar doesn't change until this number for some reason
    private const float trueFillMaximum = 0.842f;

    public void SetHealth(int Health)
    {
        
        if (Health != CurrentHealth)
        {
            if (Health >= MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            else
            {
                CurrentHealth = Health;
            }
            
            CurrentPercent = (float)CurrentHealth / (float)(MaxHealth);

            HealthPercent.text = string.Format("{0} %", Mathf.RoundToInt(CurrentPercent * 100));

            HealthBar.fillAmount = CurrentPercent*trueFillMaximum;
        }
    }

    public float CurrentPercent2
    {
        get { return CurrentPercent; }
    }

    public int CurrentValue
    {
        get { return CurrentHealth; }
    }


    //Use this for initialization
    void Start()
    {
        MaxHealth = 100;
        SetHealth(MaxHealth);
        MinHealth = 0;
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
        //if (other.name == "Enemy")
        //{
            //SetHealth(CurrentHealth - 10);
            //CurrentHealth = CurrentHealth - 10;
            //print(CurrentPercent);
            //HealthPercent.text = CurrentPercent + "%";
        //}

        //if (other.name == "Health (1)")
        //{
        //    CurrentPercent = MaxHealth + 10;
        //    HealthPercent.text = CurrentPercent + "%";
        //}

    //}
    
}