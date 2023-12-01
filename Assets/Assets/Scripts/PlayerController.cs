using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        MoveAroundCylinder(horizontalInput);
    }

    void OnCollisionEnter(Collision other)
    {
        // Collision check
        if (other.gameObject.CompareTag("Obstacle"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Debug.Log(rb.velocity.y);
        }
    }

    private void MoveAroundCylinder(float horizontalInput)
    {
        // Vector3 direction = new Vector3(horizontalInput, 0, 0).normalized;
        transform.RotateAround(Vector3.zero, Vector3.up, -horizontalInput * moveSpeed * Time.deltaTime);
    }
}