using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int MaxHealth = 100;
    public int CurrentHealth;
    public string HealthText;
    

	// Use this for initialization
	void Start () {

        CurrentHealth = MaxHealth;
<<<<<<< Updated upstream
        for (int MaxHealth = 100; 100 > 1; MaxHealth--);
            print(CurrentHealth + "Health");
=======
        for (int MaxHealth = 0; 100 < 1; MaxHealth--);
>>>>>>> Stashed changes
            
		
	}
	 
	void Update()
    { if (CurrentHealth < 0)
       print("You are Dead" + HealthText);


    }
        }
    

