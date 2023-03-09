using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeMoveSpeedGalaxy : MonoBehaviour
{
    private ActionBasedContinuousMoveProvider continuousMoveProvider;

    private void Start()
    {
        // Get the ContinuousMoveProvider component
        continuousMoveProvider = GetComponent<ActionBasedContinuousMoveProvider>();
    }

    private void Update()
    {
        float r = this.gameObject.transform.position.magnitude;
        float speed;
        if (r < 200)
        {
            speed = 10 + 90 * (r / 200);
        }
        else
        {
            speed = 1000;
        }
        continuousMoveProvider.moveSpeed = speed;
    }
}
