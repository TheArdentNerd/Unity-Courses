using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class HelloWorld : MonoBehaviour

{
    
    void Start()
    {
        // this is how we create a new object of type person
        Person john = new Person();
        john.FirstName = "John";
        john.LastName = "Smith";
        john.Introduce();
    }

    void Update()
    {
        
    }
}
