using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target that the camera will follow
    public Vector3 offset; // Offset value between the camera and the target
    public float smoothSpeed = 0.125f; // Speed at which the camera will follow

    void FixedUpdate()
    {
        // Desired position of the camera
        Vector3 desiredPosition = target.position + offset;
        // Smoothly interpolate between the camera's current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Set the camera's position to the smoothed position
        transform.position = smoothedPosition;

        // Optionally, make the camera look at the target
        transform.LookAt(target);
    }
}
