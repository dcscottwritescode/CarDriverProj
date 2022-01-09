using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float crashSpeed = 0.01f;
    [SerializeField] float boostSpeed = 0.01f;
    void Start()
    {

    }

    void Update()
    {
     float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
     float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
     transform.Rotate(0, 0, -steerAmount);
     transform.Translate(0, speedAmount, 0);          
    }
}
