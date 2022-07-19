using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        List<float> myList = new List<float>();
        myList.Add(2);
        for (int i = 2; i < 21; i += 2) 
        {
           myList.Add(i); print(i);
        }

        
    }

    private void Update()
    {
        
    }




}














// Update is called once per frame



