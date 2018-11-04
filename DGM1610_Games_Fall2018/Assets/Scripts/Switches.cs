using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int num;
	public string Name;
    public int Time;
    public int Temp;
    public string Quadrant;
    public bool Beep;
    public string Cats;

	// Use this for initialization
	void Start () {

			//if(num == 10)
				//print("you picked ten!");

			
			//else
				//print("Boo! You didn't pick ten!");
			
			//switch(num){

				//case 1:
					//print("you picked" + num);
				//break;

				//case 3:
				//	print("you picked" + num);
				//break;

			//	case 6:
				//	print("you picked" + num);
				//break;

				//case 10:
					//print("you picked" + num);
				//break;
				//default:
					//print("I don't understand" + num);
					//break;			
		//}

		switch(Name){
			case "Jason":
				print("Welcom to camp crystal lake" + Name + "- love mother");
			    break;

			case "Michael":
				print("Welcome to Haddonfield, Ill" + Name);
			    break;

			case "Freddie":
				print("Welcome to Elm Street" + Name);
			    break;

			case "LeatherFace":
				print("The stars and stripes are big at night...Deep in the heart of Texas");
			    break;

			default:
				print("I dont know" + Name);
			    break;
		}

        switch(Time){
            case 12:
                print("The sun is shining at" + Time);
                break;

            case 5:
                print("The sun is setting at" + Time);
                break;

            case 9:
                print("the sun is down at" + Time);
                break;
        }

        switch(Quadrant){
            case "One":
                print("You are in the northeast section" + Quadrant);
                break;

            case "Two":
                print("You are in the northwest section" + Quadrant);
                break;

            case "Three":
                print("You are in the southwest section" + Quadrant);
                break;

            case "Four":
                print("You are in the southeast section" + Quadrant);
                break;
        }

        switch(Temp){
            case 80:
                print("It is hot when it is" + Temp);
                break;

            case 40:
                print("It is chilly when it is" + Temp);
                break;

            case 10:
                print("It is freezing when it is" + Temp);
                break;
        }

        //switch(Beep){
        //case on:
        // print("It is" + Beep);
        // break;

        //case off:
        // print("It is" + Beep);
        // break;
        // }

        switch(Cats){
            case "black":
                print("The best cat for Halloween is" + Cats);
                break;

            case "white":
                print("A blue eyed cat is likely to be" + Cats);
                    break;

            case "orange":
                print("Big cats are usually" + Cats);
                break;
        }

         
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
