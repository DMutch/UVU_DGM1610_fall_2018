using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int num;
	public string Name;

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
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
