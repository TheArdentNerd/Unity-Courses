using UnityEngine;

public class Person
{
    public string FirstName;
    public string LastName;   

    public void Introduce()
    {
        Debug.Log("My name is " + FirstName + " " + LastName);
    }
}
