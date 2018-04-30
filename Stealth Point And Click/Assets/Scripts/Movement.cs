
using UnityEngine;

public class Movement : MonoBehaviour {
    public float speed = 10f;
    public float right = 10f;
    public float left = 10f;
    public Rigidbody rb;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(0, 1, speed * Time.deltaTime);
    if ( Input.GetKey("d"))
        {
            rb.AddForce(right, 0, 0 * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-right, 0, 0 * Time.deltaTime);
        }
    }

}