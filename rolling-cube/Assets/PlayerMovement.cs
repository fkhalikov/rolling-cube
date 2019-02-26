using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Use this for initialization
  
	// Update is called once per frame
	void FixedUpdate () {
        

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, 100 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
