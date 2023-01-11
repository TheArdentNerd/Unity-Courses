using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var number = "1234";
        int i = Convert.ToInt32(number);
        Debug.Log(i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
