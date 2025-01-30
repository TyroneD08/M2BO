using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleJump : MonoBehaviour
{
    public float jumpForce = 5f; // Force for the jump
    [SerializeField]
    private bool isGrounded = true; // Tracks if the player is on the ground

    private Rigidbody rb; // Rigidbody for physics
    private Animator animator; // Animator for animations

    void Start()
    {
        // Get the Rigidbody and Animator components
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for the jump input
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        // Apply an upward force
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);

        // Trigger the jump animation
        animator.SetTrigger("jump");

        // Set isGrounded to false
        isGrounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player lands on the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}

