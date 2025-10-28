using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 6;


    void Start()
    {
        myInt = MultiplyBySeven(myInt);
        Debug.Log(myInt);
    }


    int MultiplyBySeven(int number)
    {
        int result;
        result = number * 7;
        return result;
    }
}