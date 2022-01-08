using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Gotta go fast!");
    }
}
