using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the character moves

    private Rigidbody2D rb; // Reference to the Rigidbody2D component

    void Start()
    {
        // Get reference to the Rigidbody2D component attached to the character GameObject
        rb = GetComponent<Rigidbody2D>();
        if (rb == null) {
            Debug.LogError("Rigidbody2D component not found on " + gameObject.name + "! Please attach one.");
            return; // Exit the function if no Rigidbody2D is found
        }
    }

    void Update()
    {
         // If Rigidbody2D is not attached, skip updating movement
        if (rb == null) return;
        
        // Get horizontal and vertical input from keyboard
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Check if there's any input
        if (movement.magnitude > 0)
        {
            // Normalize movement vector to ensure consistent speed diagonally
            movement.Normalize();

            // Move the character based on input
            rb.velocity = movement * moveSpeed;
        }
        else
        {
            // If no input, stop the character
            rb.velocity = Vector2.zero;
        }
    }
}
