using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys, but limit rotation on unwanted axis
        Vector3 rotation = transform.rotation.eulerAngles;
        rotation.x += verticalInput * rotationSpeed * Time.deltaTime;

        // Adjust the rotation, ensuring no unintended roll or yaw
        rotation.z = 0f;  // Prevent any unintended roll or side movement
        rotation.y = 0f;  // Prevent any yaw movement if it's not desired

        transform.rotation = Quaternion.Euler(rotation);
    }
}
