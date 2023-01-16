using UnityEngine;
using System;

public class Person
{
    public string FirstName;
    public string LastName;   

    public void Introduce()
    {
        Debug.Log("My name is " + FirstName + " " + LastName);
        var firstName = "Levi";
        String lastName = "Binder";

        var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

        var names = new string[3] {"John","Jack","Mary"};

        var formattedNames = string.Join(",", names);
        Debug.Log(formattedNames);
    }
}
