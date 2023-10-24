using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 2000f;
    public float sideway = 700f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, force * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < 0.9f)
        {
            FindAnyObjectByType<Manager>().EndGame();
        }
    }
}
