using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	public int Num = 40;
    public int Age;
	public string Color = "Blue";
    
    // Use this for initialization
    void Start()
    {
        // for(int i=0; i <= 100; i++){

        // print(i + "Ants Marching");

        // }

        // while(Num >= 0){
        // print("Countdown" + Num);
        // Num --;
        // }

        while (Color == "Red")
        {
            print("Color is" + Color);
        }

         while (Age >= 16 || Age <= 100)
         {
         print("DrivingAge is" + Age);
            break;
        }

         while (Age >= 15)
        {
         print("DrivingAge is not" + Age);
            break;
        }
        while (Age < 21)
        {
            print("Drinking is Illegal while" + Age);
            break;
        }
        for (float RainInInches = 0; RainInInches<20; RainInInches++){

            print("RainInInches is " + RainInInches);
        }
        for (int Temp = 0; Temp<100; Temp++)
        {
            print("Temperature is " + Temp);
        }
        for (int CookTime = 60; CookTime>=1; CookTime--)
        {
            print("CookTime is " + CookTime);
        }
        
       
    
    }
// Update is called once per frame
void Update () {
		
	}
}
