using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    //this is the variable that is referring to the rigidbody called "rb"
    public Rigidbody rb; 

    // FixedUpdate is called because we are using physics 
    // to update the rigidbody's motion
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 1000 * Time.deltaTime); //Adding a force of 1000 on the z-axis
    }
}
