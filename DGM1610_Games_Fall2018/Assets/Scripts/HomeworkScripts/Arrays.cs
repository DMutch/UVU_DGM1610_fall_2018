using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public int[] Eggs = new int[11];

	public string[] Jedi;

    public int[] InchesOfRain;

    public string[] Dogs;

	public string[] Pets;
     

	// Use this for initialization
	void Start () {
		

	//	Eggs[0] = 1;
	//	Eggs[1] = 2;
	//	Eggs[2] = 3;
	//	Eggs[3] = 4;
	//	Eggs[4] = 5;
	//	Eggs[5] = 6;
	//	Eggs[6] = 7;
	//	Eggs[7] = 8;
	//	Eggs[8] = 9;
	//	Eggs[9] = 10;
	//	Eggs[10] = 11;
	//	Eggs[11] = 12;

		//print(Eggs[8]);


		Jedi = new string[4];

		Jedi[0] = "Obi Wan Kenobi";
		Jedi[1] = "Yoda";
		Jedi[2] = "Mace Windu";
		Jedi[3] = "Kit Fisto";
		Jedi[4] = "Luke Skywalker";

		foreach(string item in Jedi){
			print("Jedi master" + item);
		}

        InchesOfRain = new int[3];

        InchesOfRain[0] = 0;
        InchesOfRain[1] = 5;
        InchesOfRain[2] = 10;
        InchesOfRain[3] = 15;

        foreach(int item in InchesOfRain){
            print("Inches rained today" + item);
        }

        Dogs = new string[5];

        Dogs[0] = "Boxer";
        Dogs[1] = "PitBull";
        Dogs[2] = "Poodle";
        Dogs[3] = "Dalmation";
        Dogs[4] = "Husky";
        Dogs[5] = "BirdDog";

        foreach(string item in Dogs){
            print("Make sure and feed your" + item);
        }

        for (int InchesOfRain = 0; InchesOfRain<15; InchesOfRain++){
            print("It rained" + InchesOfRain);
        }

		
		Pets = new string [5];

		Pets[0] = "Dogs";
		Pets[1] = "Cats";
		Pets[2] = "Birds";
		Pets[3] = "Ferrets";
		Pets[4] = "Hamsters";
		Pets[5] = "Fish";

		foreach(string item in Pets){
			print("My former pets are" + item);
		}

         
        
       







    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
