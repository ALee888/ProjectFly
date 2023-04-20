using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform target; // the player object
    public float  smoothSpeed = 0.125f;

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPosition = target.position + new Vector3(0, 0, -20); // the desired position of the camera
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // smooth the camera movement
        transform.position = smoothedPosition; // update the camera position
    }
}
