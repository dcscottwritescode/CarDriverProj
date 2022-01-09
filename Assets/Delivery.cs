using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 packagePickedUp = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 packageNotPickedUp = new Color32 (1, 1, 1, 1);

    [SerializeField] float destroyDelay = 1.0f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Your boss won't be happy about that...");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("You have picked up the package! Deliver it to the destination.");
            hasPackage = true;
            spriteRenderer.color = packagePickedUp;
            Destroy(other.gameObject, destroyDelay); 
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("You have succesfully delivered the package! Pick up the next one.");
            hasPackage = false;
            spriteRenderer.color = packageNotPickedUp;
        }

        if (other.tag == "Boost")
        {
            Debug.Log("Gotta go fast!");
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if (other.tag == "Package" && hasPackage == true)
        {
            Debug.Log("Already have a package to deliver...");
        }   
    }    
}