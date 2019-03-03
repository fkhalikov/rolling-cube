using UnityEngine;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce= 500f;
    public float moveTolerance = 0.9f;
    public ForceMode sideWayMode = ForceMode.Force;
    public ForceMode forwardMode = ForceMode.Force;
    public ForceMode jumpMode = ForceMode.Force;

    // Use this for initialization
    
	// Update is called once per frame
	void FixedUpdate () {
      

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        rb.AddForce(0, 0, forwardForce * Time.deltaTime, forwardMode);

        if ((Math.Abs(rb.position.y - 1) < moveTolerance) == false) return;
                
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, sideWayMode);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, sideWayMode);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, forwardMode);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, forwardMode);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, jumpMode);
        }

       
    }
}
