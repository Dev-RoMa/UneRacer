using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;      // Speed at which the car moves forward and backward
    public float rotateSpeed = 100f;  // Speed at which the car rotates

    // Update is called once per frame
    void Update()
    {
        // Get the input for movement and rotation
        float moveInput = Input.GetAxis("Vertical");    // Up/Down arrow keys or W/S keys
        float rotateInput = Input.GetAxis("Horizontal"); // Left/Right arrow keys or A/D keys

        // Move the car forward or backward
        transform.Translate(Vector2.up * moveInput * moveSpeed * Time.deltaTime);

        // Rotate the car
        transform.Rotate(Vector3.forward, -rotateInput * rotateSpeed * Time.deltaTime);
    }
}
