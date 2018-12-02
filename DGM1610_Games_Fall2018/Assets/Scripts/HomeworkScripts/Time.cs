using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time: MonoBehaviour {
    internal static int timeScale;
    public string TimeOfDay;

	// Use this for initialization
	void Start () {

        if (TimeOfDay == "Morning")
            print("TimeOfDay is" + TimeOfDay);
        else if (TimeOfDay == "Afternoon")
            print("TimeOfDay is" + TimeOfDay);
        else if (TimeOfDay == "Evening")
            print("TimeOfDay is" + TimeOfDay);
        else if (TimeOfDay == "Night")
            print("TimeOfDay is" + TimeOfDay);

        else
            print("TimeOfDay is" + TimeOfDay);
		
	}
	
	 
	 
}
