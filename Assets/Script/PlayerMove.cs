using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1200f;
    public float sidewaysForce = 1000f;

    private void FixedUpdate() {
        // Debug.Log((Time.fixedTime * forwardForce) * Time.deltaTime);
        rb.AddForce(0, 0,  forwardForce * Time.deltaTime);

        if(Input.GetKey("right")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("left")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
