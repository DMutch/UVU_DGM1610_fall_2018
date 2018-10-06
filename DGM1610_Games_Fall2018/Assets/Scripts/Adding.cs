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

    void Add(int One, int Two){
        Total = One + Two;
        print(Total);
    }
}

