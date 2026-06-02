using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallController : MonoBehaviour
{
    [Header("Physics Settings")]
    public float speed = 15f;
    private Rigidbody rb;

    void Start()
    {
        // Cache the Rigidbody reference to save memory overhead
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Read the native accelerometer data from the mobile device
        Vector3 tilt = Input.acceleration;
        
        // Map the X and Y tilt of the phone to the X and Z floor axes
        Vector3 movement = new Vector3(tilt.x, 0.0f, tilt.y);
        
        // Apply continuous force to the physics engine
        rb.AddForce(movement * speed);
    }
}
