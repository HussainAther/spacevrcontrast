using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleController : MonoBehaviour
{
    public float scaleSpeed = 0.1f; // The speed at which the object will scale

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) // Scale up when the up arrow key is pressed
        {
            transform.localScale += new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow)) // Scale down when the down arrow key is pressed
        {
            transform.localScale -= new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
        }
    }
}
