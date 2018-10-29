using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adding : MonoBehaviour
{
 
    public int Num1;
    public int Num2;
    private int Total;

    //Use this for initialization
    void Start() {
        Add(Num1, Num2);
    }

    void Add(int Num1, int Num2){
        Total = Num1 + Num2;
        print(Total);
    }
}

