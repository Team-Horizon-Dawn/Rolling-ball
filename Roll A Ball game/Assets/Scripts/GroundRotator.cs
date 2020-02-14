using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRotator : MonoBehaviour
{
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalTilt = Input.GetAxis("Horizontal");
        float verticalTilt = Input.GetAxis("Vertical");

        Quaternion rotation = Quaternion.Euler(verticalTilt, 0.0f, -horizontalTilt);
        rb.MoveRotation(rb.rotation * rotation);
    }
}
