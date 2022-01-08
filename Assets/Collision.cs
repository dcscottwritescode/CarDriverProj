using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Your boss won't be happy about that...");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package")
        {
              Debug.Log("You have picked up the package! Deliver it to the destination."); 
        }

        if (other.tag == "Customer")
        {
            Debug.Log("You have succesfully delivered the package! Pick up the next one.");
        }
    }    
}