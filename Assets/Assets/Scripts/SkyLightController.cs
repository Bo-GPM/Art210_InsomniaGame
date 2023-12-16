using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SkyLightController : MonoBehaviour
{
    public Transform player;
    public float rotationSpeed;

    private float playerHeight;
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = rotationSpeed * -0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        playerHeight = player.position.y;
        float xAngle = -172.3f + playerHeight * rotationSpeed;
        // Debug.Log(playerHeight);
        transform.localEulerAngles = new Vector3(xAngle, 123.837f, -233.93f);
    }
}
