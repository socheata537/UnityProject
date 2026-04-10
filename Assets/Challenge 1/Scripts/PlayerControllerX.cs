using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 25.0f;
    public float rotationSpeed = 25.0f;
    private float verticalInput = 25.0f;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        // Get input
        verticalInput = Input.GetAxis("Vertical");
        
        // Move the plane forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // Tilt the plane up/down based on up/down arrow key
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}