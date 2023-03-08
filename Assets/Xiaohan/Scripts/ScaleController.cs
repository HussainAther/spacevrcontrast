using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScaleController : MonoBehaviour
{
    public InputActionReference joystickAction; // A reference to the left hand joystick input action
    public float joystickThreshold = 0.5f; // The amount the joystick must be pushed in a direction to trigger an event

    public float scaleSpeed = 0.01f; // The speed at which we want to scale the object

    private void OnEnable()
    {
        // Enable the joystick input action
        joystickAction.action.Enable();
        // Add a listener to the joystick input action
        joystickAction.action.performed += OnJoystickInput;
    }

    private void OnDisable()
    {
        // Remove the listener from the joystick input action
        joystickAction.action.performed -= OnJoystickInput;
        // Disable the joystick input action
        joystickAction.action.Disable();
    }

    private void OnJoystickInput(InputAction.CallbackContext context)
    {
        // Get the joystick input value as a Vector2
        Vector2 input = context.ReadValue<Vector2>();

        // Check if the joystick is being pushed up or down
        if (input.y > joystickThreshold)
        {
            // Trigger the up event
            ScaleObject(1);
        }
        else if (input.y < -joystickThreshold)
        {
            // Trigger the down event
            ScaleObject(-1);
        }
    }

    private void ScaleObject(int direction)
    {
        // direction is 1 or -1
        Vector3 newScale = this.gameObject.transform.localScale + Vector3.one * scaleSpeed * direction;
        newScale.x = Mathf.Clamp(newScale.x, 1e-6f, 10f);
        newScale.y = Mathf.Clamp(newScale.y, 1e-6f, 10f);
        newScale.z = Mathf.Clamp(newScale.z, 1e-6f, 10f);

        // Apply the new scale to the target object
        this.gameObject.transform.localScale = newScale;
    }

}