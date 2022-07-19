using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  VariableTypes : MonoBehaviour
{

    public int Integer;
    float Float = 1.23456789012345678901234567890f;
    double Double = 1.23456789012345678901234567890d;
    bool Boolean = true;
    char Character = 'a';
    string String = "Hello World";

    int variableOne = 10;


    // Start is called before the first frame update
    void Start()
    {
        int variableTwo = variableOne + 3;
        print();
        print(Float);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
