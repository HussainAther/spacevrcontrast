using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[RequireComponent(typeof(Rigidbody))]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 15f; 
    public float maxSpeed = 25f; 
    private Vector3 position;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical"); 
        Vector3 movement.position = new Vector3(moveHorizontal, 0f, moveVertical);
        float minX = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        float maxX = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

        if (transform.position.x < minX || transform.position.x > maxX)
        {
            rb.velocity = 0;
        }
        else
        {
            if (rb.velocity.magnitude < maxSpeed) { rb.velocity += movement * speed * Time.deltaTime; }
        }

        if (rb.velocity.magnitude < maxSpeed){rb.velocity += movement * speed * Time.deltaTime;} 
        {
            Mathf.Clamp(movement.position.x, Boundary.xMin, Boundary.xMax);
            0.0f;
            Mathf.Clamp(movement.position.z, Boundary.zMin, Boundary.zMax);
        };
    }



}