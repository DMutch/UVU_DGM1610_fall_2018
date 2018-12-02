using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

    public Image HealthBar;

    public int MinHealth;

    public int MaxHealth;

    public Text HealthPercent;

    private int CurrentHealth;

    private float CurrentPercent;

    public void SetHealth(int Health)
    {
        if (Health != CurrentHealth)
        {
            if (MaxHealth - MinHealth == 0)
            {
                CurrentHealth = 0;
                CurrentPercent = 0;
            }
            else
            {
                CurrentHealth = Health;

                CurrentPercent = (float)CurrentHealth / (float)(MaxHealth - MinHealth);
            }

            HealthPercent.text = string.Format("{0} %", Mathf.RoundToInt(CurrentPercent * 100));

            HealthBar.fillAmount = CurrentPercent;
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
        
        
         
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Enemy")
        {
            CurrentPercent = MaxHealth - 10;
            print(CurrentPercent);
            HealthPercent.text = CurrentPercent + "%";
            

        }

        if (other.name == "Health (1)")
        {
            CurrentPercent = MaxHealth + 10;
            HealthPercent.text = CurrentPercent + "%";
            

        }

    }
    
}