using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float distanceFromPlayer = 5f;
    public float heightOffset = 2f;
    private Vector3 offset;
    
    void Start()
    {
        // Calculate init offset of camera
        offset = new Vector3(0, heightOffset, -distanceFromPlayer);
    }

    void LateUpdate()
    {
        if (player == null) return;

        // Calculate the current angle around the cylinder based on player's position
        float angle = Mathf.Atan2(player.position.x, player.position.z) * Mathf.Rad2Deg;

        // Rotate the offset around the y-axis
        Vector3 rotatedOffset = Quaternion.Euler(0, angle, 0) * offset;

        // Set the camera's position and rotation
        transform.position = player.position + rotatedOffset;
        transform.LookAt(player.position + Vector3.up * heightOffset);
    }

    void CameraBuffer()
    {
        // TODO: add camera buffer
    }
}