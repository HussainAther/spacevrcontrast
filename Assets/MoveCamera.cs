using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float movementSpeed = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.forward * Time.deltaTime*10);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector3.back * Time.deltaTime*10);
        }

        if (Input.GetKey(KeyCode.Z)) {
            transform.Translate(Vector3.forward * Time.deltaTime*100);
        }
        if (Input.GetKey(KeyCode.X)) {
            transform.Translate(Vector3.back * Time.deltaTime*100);
        }
        // float verticalMovement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        // transform.Translate(0, 0, verticalMovement);
    }
}