using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRotator : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalTilt = Input.GetAxis("Horizontal") * speed;
        float verticalTilt = Input.GetAxis("Vertical") * speed;

        Quaternion rotation = Quaternion.Euler(verticalTilt, 0.0f, -horizontalTilt);
        rb.MoveRotation(rb.rotation * rotation);
    }
}
