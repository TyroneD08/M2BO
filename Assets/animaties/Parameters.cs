using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed = 5f;

    private void Update()
    {
        // Beweging ophalen
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        // Snelheid berekenen
        float speed = movement.magnitude;

        // Animator parameter bijwerken
        animator.SetFloat("Speed", speed);

        // Speler bewegen
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
}

