using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
     [SerializeField] Color hasPackageColor = new Color (255, 255, 255, 255);
     [SerializeField] Color noPackageColor = new Color (255, 255, 255, 255);
     [SerializeField] float destroySpeed = 1f;
     bool hasPackage;

     SpriteRenderer spriteRenderer;
     // Type first then the variable
     void Start() 
     {
          spriteRenderer = GetComponent<SpriteRenderer>();
     }
   void OnCollisionEnter2D(Collision2D other) 
   {
        Debug.Log("Ouch!");
   }
   void OnTriggerEnter2D(Collider2D other) 
   {
          if (other.tag == "Package" && !hasPackage)
          {
             Debug.Log("Package picked up!");
             hasPackage = true;
             Destroy(other.gameObject, destroySpeed);
             spriteRenderer.color = hasPackageColor;
          }
          if (other.tag == "Customer" && hasPackage)
          {
               Debug.Log("Package dropped off!");
               hasPackage = false;
               spriteRenderer.color = noPackageColor;
               
          }
   }

}

// When we bump into something we can get information and/or change information with the (Collision2D other)
