using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallerinaRotate : MonoBehaviour
{
    public float rotationSpeed = 10f;
    private bool isRotating = false;

    private void Update()
    {
        if (isRotating)
        {
            // Rotate the object around its Z-axis continuously
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }

    public void StartRotating()
    {
        Invoke("EnableRotation", 1f); // Wait for 1 second and enable rotation
    }

    private void EnableRotation()
    {
        isRotating = true;
    }
}
