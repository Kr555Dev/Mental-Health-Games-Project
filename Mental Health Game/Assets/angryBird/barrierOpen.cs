using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierOpen : MonoBehaviour
{
    public float moveDistance = 2.0f; // Distance to move the object downward.
    public float moveSpeed = 5.0f;    // Speed at which the object moves.

    private bool isMoving = false;    // Flag to track if the object is moving.
    private Vector3 initialPosition;  // Initial position of the object.
    private Vector3 targetPosition;   // Target position after moving down.
    
    private void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition - new Vector3(0f, moveDistance, 0f);
    }

    private void Update()
    {
        // Check if the object is moving and move it toward the target position.
        if (isMoving)
        {
            float step = moveSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

            // Check if the object has reached the target position.
            if (transform.position == targetPosition)
            {
                isMoving = false; // Stop moving when the target is reached.
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the trigger has been entered by the player or another object.
        if (other.CompareTag("Player"))
        {
            // Start moving the object down when triggered by the player.
            isMoving = true;
        }
    }
}

